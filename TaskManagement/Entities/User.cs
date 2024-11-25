﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Entities
{
    public class User : IdentityUser<int>
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string Code { get; set; }
        [PersonalData]
        public int DepartmentId { get; set; }
        [PersonalData]
        public TblDmDepartment Department { get; set; }
        public List<TblComment> Comments { get; set; }
        public List<TaskUser> TaskUsers { get; set; }
    }
}
