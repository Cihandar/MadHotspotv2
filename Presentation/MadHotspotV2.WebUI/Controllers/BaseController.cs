using MadHotspotV2.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadHotspotV2.WebUI.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public static Guid CompanyId { get; set; }
        public bool isAdmin { get; set; }
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var ssee = HttpContext.RequestServices.GetService<UserManager<AppUser>>();
                var _userManager = context.HttpContext.RequestServices.GetService<UserManager<AppUser>>();
                var user = _userManager.FindByEmailAsync(context.HttpContext.User.Identity.Name).Result;
                if (user == null)
                {
                    user = _userManager.FindByNameAsync(context.HttpContext.User.Identity.Name).Result;

                    if (user != null)
                    {
                        CompanyId = user.CompanyId;
                        ViewBag.isAdmin = user.Admin;
                        isAdmin = user.Admin;
                        return;
                    }

                    context.Result = new RedirectToRouteResult("Home");
                    return;
                }
                else
                {
                    CompanyId = user.CompanyId;
                    ViewBag.PermissionEnum = user.UserType;
                    ViewBag.isAdmin = user.Admin;
                    isAdmin = user.Admin;
                }
            }
        }
    }
}
