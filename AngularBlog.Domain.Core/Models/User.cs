﻿namespace AngularBlog.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // TODO secure somehow
    }
}