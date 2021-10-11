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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioAgendamiento _repoAgendamiento;
        public IEnumerable<Agendamiento> agendamientos {get; set;}
        public IndexModel(IRepositorioAgendamiento repoAgendamiento)
        {
            _repoAgendamiento = repoAgendamiento;
        }

        public void OnGet()
        {
            agendamientos = _repoAgendamiento.GetAllAgendamientos();
        }
    }
}
