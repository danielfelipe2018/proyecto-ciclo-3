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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> pacientes {get; set;}
        public int gActual{get;set;}
        public string bActual{get;set;}
        public IndexModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        }

        public void OnGet(int? g, string b)
        {
            if  (g.HasValue && g.Value!=-1)
            {
                gActual=g.Value;
                pacientes =_repoPaciente.GetPacientesGenero(g.Value);
            }
            else
            {
                gActual=-1;
                if(String.IsNullOrEmpty(b))
                {
                    bActual="";    
                    pacientes = _repoPaciente.GetAllPacientes();  
                }
                else
                {
                    bActual=b;
                    pacientes=_repoPaciente.BuscarPacientes(b);    
                }
            }
            
        }
    }
}
