﻿using System.Collections.Generic;
using Simple_forum.Models;

namespace Simple_forum.ViewModels.Logins
{
    public class LoginRegisterViewModel
    {
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }
        public bool LoginRememberMe { get; set; }
        public string RegisterEmail { get; set; }
        public string RegisterName { get; set; }
        public string RegisterPassword { get; set; }
        public string RegisterPasswordConfirm { get; set; }
        public bool Error { get; set; }
    }
}
