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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get;set;}
        public DetailsModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }
        
        public IActionResult OnGet(int id)
        {
            medico = _repoMedico.GetMedico(id);
            if (medico==null)
            {
                return NotFound();
            } 
            else
            {
                return Page();
            }
        }
    }
}
