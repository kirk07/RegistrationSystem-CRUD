using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationSystem.Models;

namespace RegistrationSystem.Pages.Forms
{
    public class EditModel : PageModel
    {
        public EditModel(RegistrationDBContext PersonDBcontext)
        {
            _persondbcontext = PersonDBcontext;
        }
        //create property for DBContext instance
        private readonly RegistrationDBContext _persondbcontext;

        [BindProperty]
        public Person edit { get; set; }

        public void OnGet(int ID)
        {
            edit = _persondbcontext.Persons.
              FirstOrDefault(pesons => pesons.PersonID == ID);
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
       
            var person = _persondbcontext.Persons.FirstOrDefault(person => person.PersonID == edit.PersonID);


            if (person != null)
            {
         
                person.Name = edit.Name;
                person.Email = edit.Email;
                person.Address = edit.Address;
                person.Contact= edit.Contact;
                person.Age = edit.Age;
                person.Gender = edit.Gender;
                person.Password = edit.Password;


                _persondbcontext.Update(person);
                _persondbcontext.SaveChanges();
            }
            return Redirect("/Index");

        }
    }
}
