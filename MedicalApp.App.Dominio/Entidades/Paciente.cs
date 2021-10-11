using System.ComponentModel.DataAnnotations;


namespace MedicalApp.App.Dominio
{
    public class Paciente : Persona
    {
        //public int Codigo {get; set;}
        [Display (Name="Tipo de Paciente")]
        public TipoPaciente TipoPaciente {get; set;}
        [Display (Name="Tiene Convenio?")]
        public Convenio Convenio {get; set;}
    }
}