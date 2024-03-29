﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simple_forum.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public List<Topic> Topics { get; set; }
        public List<Post> Posts { get; set; }
    }
}