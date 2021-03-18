using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace RegistrationSystem.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(RegistrationDBContext PersonDBcontext)
        {
            _persondbcontext = PersonDBcontext;
        }
        //create property for DBContext instance
        private readonly RegistrationDBContext _persondbcontext;

        [BindProperty]
        public Person Register { get; set; }

        public List<Person> Persons = new List<Person>();
        public void OnGet()
        {
            Persons = _persondbcontext.Persons.ToList();
        }

    }
}
