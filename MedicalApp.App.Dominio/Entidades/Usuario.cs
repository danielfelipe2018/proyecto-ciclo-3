namespace MedicalApp.App.Dominio
{
    public class Usuario
    {
        public int Id {get; set;}
        public Paciente Paciente {get; set;}
        public string NombreUsuario {get; set;}
        public string Password {get; set;}
    }
}