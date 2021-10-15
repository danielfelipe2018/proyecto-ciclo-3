using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.FrontEnd.Pages.Agendamientos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioAgendamiento _repoAgendamiento;
        public Agendamiento agendamiento {get;set;}
        public EditModel(IRepositorioAgendamiento repoAgendamiento)
        {
            _repoAgendamiento = repoAgendamiento;
        }
        
        public IActionResult OnGet(int id)
        {
            agendamiento = _repoAgendamiento.GetAgendamiento(id);
            if (agendamiento==null)
            {
                return NotFound();
            } 
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Agendamiento agendamiento)
        {
            if(ModelState.IsValid)
            {
                _repoAgendamiento.UpdateAgendamiento(agendamiento);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }

    }
}
