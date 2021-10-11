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
    public class AddCiudadModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        private readonly IRepositorioCiudad _repoCiudad;
        public IEnumerable<Ciudad> ciudades {get; set;}
        public Sede sede {get;set;}
        public AddCiudadModel(IRepositorioSede repoSede,IRepositorioCiudad repoCiudad)
        {
            _repoSede = repoSede;
            _repoCiudad = repoCiudad;
        }
        public void OnGet(int id)
        {
            sede = _repoSede.GetSede(id);
            ciudades = _repoCiudad.GetAllCiudades();
        }

        public IActionResult OnPost(int idSede, int idCiudad)
        {
            _repoSede.AsignarCiudad(idSede,idCiudad);
            return RedirectToPage("Details", new{id=idSede});
        }
    }
}
