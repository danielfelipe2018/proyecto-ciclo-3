namespace MedicalApp.App.Dominio
{
    public class Paciente : Persona
    {
        //public int Codigo {get; set;}
        public TipoPaciente TipoPaciente {get; set;}
        public Convenio Convenio {get; set;}
    }
}