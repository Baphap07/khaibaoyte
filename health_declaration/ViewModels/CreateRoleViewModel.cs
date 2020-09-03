using System;
using System.ComponentModel.DataAnnotations;

namespace health_declaration.ViewModels
{
    public class CreateRoleViewModel
    {
        
            [Required]
            public string RoleName { get; set; }
        
    }
}
