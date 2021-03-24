using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationSystem.Models
{
    public class Person
    {
        //scalar
        public int PersonID { get; set; }
       
        [StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        [Required, StringLength(20)]
        public string Contact { get; set; }

        [Required, Range(16, 99)]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 6)]
        [Compare("Password")]
        [NotMapped] // Does not effect with your database
        public string ConfirmPassword { get; set; }

    }
}
