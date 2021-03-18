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
       
        public string Email { get; set; }
       
        public string Address { get; set; }
       
        public string Contact { get; set; }
       
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }

   
        [StringLength(8, MinimumLength = 6)]
        public string Password { get; set; }

        [StringLength(8, MinimumLength = 6)]
        [Compare("Password")]
        [NotMapped] // Does not effect with your database
        public string ConfirmPassword { get; set; }

    }
}
