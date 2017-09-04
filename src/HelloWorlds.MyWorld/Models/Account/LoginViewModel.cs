﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloWorlds.MyWorld.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string UserName
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password
        {
            get;
            set;
        }

    }
}