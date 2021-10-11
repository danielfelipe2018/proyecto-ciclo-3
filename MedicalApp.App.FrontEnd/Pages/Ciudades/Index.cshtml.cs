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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad;
        public IEnumerable<Ciudad> ciudades {get; set;}
        public IndexModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        }

        public void OnGet()
        {
            ciudades = _repoCiudad.GetAllCiudades();
        }
    }
}
