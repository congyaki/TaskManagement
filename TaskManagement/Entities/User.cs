﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    public class User : IdentityUser
    {
        [PersonalData]
        public int DepartmentId { get; set; }
        [PersonalData]
        public Department Department { get; set; }
    }
}
