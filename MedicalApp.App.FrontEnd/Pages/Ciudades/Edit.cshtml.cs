using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.FrontEnd.Pages.Ciudades
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad;
        public Ciudad ciudad {get;set;}
        public EditModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        }
        
        public IActionResult OnGet(int id)
        {
            ciudad = _repoCiudad.GetCiudad(id);
            if (ciudad==null)
            {
                return NotFound();
            } 
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Ciudad ciudad)
        {
            if(ModelState.IsValid)
            {
                _repoCiudad.UpdateCiudad(ciudad);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
