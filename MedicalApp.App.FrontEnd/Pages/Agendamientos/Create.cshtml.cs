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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioAgendamiento _repoAgendamiento;
        public Agendamiento agendamiento {get;set;}
        public CreateModel(IRepositorioAgendamiento repoAgendamiento)
        {
            _repoAgendamiento = repoAgendamiento;
        }

        public void OnGet()
        {
            agendamiento = new Agendamiento();
        }
        public IActionResult OnPost(Agendamiento agendamiento)
        {
            if(ModelState.IsValid)
            {
                _repoAgendamiento.AddAgendamiento(agendamiento);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
