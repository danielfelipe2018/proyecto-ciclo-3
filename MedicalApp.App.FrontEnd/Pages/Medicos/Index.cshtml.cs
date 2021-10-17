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
        public int gActual2{get;set;}
        public string bActual{get;set;}
        public IndexModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        }

        //public void OnGet()
        //{
        //    medicos = _repoMedico.GetAllMedicos();
        //}

        public void OnGet(int? g2,string b)
        {
            if  (g2.HasValue && g2.Value!=-1)
            {
                gActual2=g2.Value;
                medicos =_repoMedico.GetMedicosEspecialidad(g2.Value);
            }
            else
            {
                gActual2=-1;
                //medicos = _repoMedico.GetAllMedicos();
                if(String.IsNullOrEmpty(b))
                {
                    bActual="";    
                    medicos = _repoMedico.GetAllMedicos();  
                }
                else
                {
                    bActual=b;
                    medicos=_repoMedico.BuscarMedicos(b);    
                }
            }
            
        }
    }
}

