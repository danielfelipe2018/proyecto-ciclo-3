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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad;
        public Ciudad ciudad {get;set;}
        public CreateModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        }

        public void OnGet()
        {
            ciudad = new Ciudad();
        }
        public IActionResult OnPost(Ciudad ciudad)
        {
            if(ModelState.IsValid)
            {
                _repoCiudad.AddCiudad(ciudad);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
