using FluentValidation.AspNetCore;
using MadHotspotV2.Application.Mappers;
using MadHotspotV2.Application.Validators.Companies;
using MadHotspotV2.Domain.Entities;
using MadHotspotV2.Persistence;
using MadHotspotV2.Persistence.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MadHotspotV2.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddPersistenceServices(); //Persistence IOC
            services.AddControllers().AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateCompanyValidator>());
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 2;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredUniqueChars = 0;
                options.Lockout = new LockoutOptions { AllowedForNewUsers = false };
                options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;
            })
               .AddEntityFrameworkStores<MadHotspotV2DbContext>()
               .AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "usernotfound",
                    pattern: "/usernotfound",
                    defaults: new { controller = "Error", action = "UserNotFound" });

                endpoints.MapControllerRoute(
                    name: "notfound",
                    pattern: "/notfound",
                    defaults: new { controller = "Error", action = "NotFound" });

                endpoints.MapControllerRoute(
                    name: "unauthorized",
                    pattern: "/unauthorized",
                    defaults: new { controller = "Auth", action = "Unauthorized" });

                endpoints.MapControllerRoute(
                    name: "authentication",
                    pattern: "/authentication",
                    defaults: new { controller = "Auth", action = "Login" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
