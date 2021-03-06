﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.web.Models
{
    public class UserModel
    {
        public string UserId { get; set; }

        public string FullName { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string CreatedAt { get; set; }

        public string Status { get; set; }

        public string AuthToken { get; set; }
    }
}