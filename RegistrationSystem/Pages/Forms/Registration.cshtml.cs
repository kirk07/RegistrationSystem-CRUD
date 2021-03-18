using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RegistrationSystem.Pages.Forms
{
    public class RegistrationModel : PageModel
    {
        public RegistrationModel(RegistrationDBContext PersonDBcontext)
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
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Persons = _persondbcontext.Persons.ToList();
                return Page();
            }
            _persondbcontext.Persons.Add(Register);
            _persondbcontext.SaveChanges();
            return Redirect("/Index");
        }

    }
}
