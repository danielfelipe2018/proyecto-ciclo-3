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
        private readonly IRepositorioSede _repoSede;
        private readonly IRepositorioMedico _repoMedico;
        private readonly IRepositorioPaciente _repoPaciente;
        //private readonly IRepositorioCiudad _repoCiudad;
        public Agendamiento agendamiento {get;set;}
        public IEnumerable<Sede> sedes {get; set;}
        public IEnumerable<Medico> medicos {get; set;}
        public IEnumerable<Paciente> pacientes {get; set;}
       // public IEnumerable<Ciudad> ciudades {get; set;}
        //public CreateModel(IRepositorioAgendamiento repoAgendamiento,IRepositorioSede repoSede,IRepositorioCiudad repoCiudad)
        public CreateModel(IRepositorioAgendamiento repoAgendamiento,IRepositorioSede repoSede,IRepositorioMedico repoMedico,IRepositorioPaciente repoPaciente)
        {
            _repoAgendamiento = repoAgendamiento;
            _repoSede = repoSede;
            _repoMedico = repoMedico;
            _repoPaciente = repoPaciente;
          //  _repoCiudad = repoCiudad;
        }

        public void OnGet()
        {
            agendamiento = new Agendamiento();
            sedes = _repoSede.GetAllSedes();
            medicos = _repoMedico.GetAllMedicos();
            pacientes =_repoPaciente.GetAllPacientes();
          //  ciudades = _repoCiudad.GetAllCiudades();
        }
        public IActionResult OnPost(Agendamiento agendamiento, int idPaciente, int idMedico)
        {
            if(ModelState.IsValid)
            {
                _repoAgendamiento.AddAgendamiento(agendamiento);
                _repoAgendamiento.AsignarPaciente(agendamiento.Id,idPaciente);
                _repoAgendamiento.AsignarMedico(agendamiento.Id,idMedico);
                return RedirectToPage("Index"); 
            }
            else
            {
                return Page();
            }
        }
    }
}
