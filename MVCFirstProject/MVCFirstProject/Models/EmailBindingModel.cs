using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFirstProject.Models
{
    public class EmailBindingModel
    {
        public int Id { get; set; }
        [Display(Name="Full Name")]
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public override string ToString()
        {
            return string.Format("{0}<{1}>",FullName,Email);
        }
    }
}