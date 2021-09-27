using System;
using System.Collections.Generic;
namespace MedicalApp.App.Dominio
{
    public class Agendamiento
    {
        public int Id {get; set;}
        public Paciente Paciente {get; set;}
        public TipoCita TipoCita {get; set;}
        public Ciudad Ciudad {get; set;}
        public Especialidad Especialidad {get; set;}
        public Sede Sede {get; set;}
        public Medico Medico {get; set;}
        public DateTime FechaCita {get; set;}
        public DateTime HoraCita {get; set;}
        public float Valor_Consulta {get; set;}
    }
}