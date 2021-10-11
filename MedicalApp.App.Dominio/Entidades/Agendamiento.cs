using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedicalApp.App.Dominio
{
    public class Agendamiento
    {
        public int Id {get; set;}
        public Paciente Paciente {get; set;}
        [Display (Name="Tipo de Cita")]
        [Required(ErrorMessage="Dato requerido")]
        public TipoCita TipoCita {get; set;}
        public Ciudad Ciudad {get; set;}
        [Required(ErrorMessage="Dato requerido")]
        public Especialidad Especialidad {get; set;}
        public Sede Sede {get; set;}
        public Medico Medico {get; set;}
        [Display (Name="Fecha de la cita")]
        [Required(ErrorMessage="Dato requerido")]
        public DateTime FechaCita {get; set;}
        public DateTime HoraCita {get; set;}
        public float Valor_Consulta {get; set;}
    }
}