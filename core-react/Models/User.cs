﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.React.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "A user name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "An operating system user is required")]
        public string OSUser { get; set; }
        [Required(ErrorMessage = "An email address is required")]
        public string Email { get; set; }
        [CheckIn(new string[] { "Admin", "User", "Read Only" })]
        public string Role { get; set; }
    }

    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "A description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "A group is required")]
        public string Group { get; set; }
    }

    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "A role name is required")]
        public string Name { get; set; }
    }
}
