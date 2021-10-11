using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.FrontEnd.Page.Pacientes
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get;set;}
        public EditModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }
        
        public IActionResult OnGet(int id)
        {
            paciente = _repoPaciente.GetPaciente(id);
            if (paciente==null)
            {
                return NotFound();
            } 
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Paciente paciente)
        {
            if(ModelState.IsValid)
            {
                _repoPaciente.UpdatePaciente(paciente);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
