using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.FrontEnd.Pages.Sedes
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        private readonly IRepositorioCiudad _repoCiudad;
        public Sede sede {get;set;}
        public IEnumerable<Ciudad> ciudades {get; set;}
        public CreateModel(IRepositorioSede repoSede,IRepositorioCiudad repoCiudad)
        {
            _repoSede = repoSede;
            _repoCiudad = repoCiudad;
        }

        public void OnGet()
        {
            sede = new Sede();
            ciudades = _repoCiudad.GetAllCiudades();
        }
        public IActionResult OnPost(Sede sede, int idCiudad)
        {
            if(ModelState.IsValid)
            {
                _repoSede.AddSede(sede);
                _repoSede.AsignarCiudad(sede.Id,idCiudad);
            
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
