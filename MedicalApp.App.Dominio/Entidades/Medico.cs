using System.ComponentModel.DataAnnotations;

namespace MedicalApp.App.Dominio
{
    public class Medico : Persona
    {
        //public int CodigoMedico {get; set;}
        [Display (Name="Especialidad médica")]
        [Required(ErrorMessage="Dato requerido")]
        public Especialidad Especialidad {get; set;}
    }
}