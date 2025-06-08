﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLab.Application.Models
{
    public class User
    {
        public int Id { get; set; }             
        public string Username { get; set; }     
        public string PasswordHash { get; set; } 
        public UserRole Role { get; set; }      
        public string FullName { get; set; }     
        public string Email { get; set; }        
    }
}
