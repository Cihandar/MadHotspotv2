﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Dtos.AppUsers
{
   public class LoginRequestDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
