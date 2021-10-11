using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.FrontEnd.Page.Medicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public IEnumerable<Medico> medicos {get; set;}
        public IndexModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }

        public void OnGet()
        {
            medicos = _repoMedico.GetAllMedicos();
        }
    }
}
