using System;
namespace MedicalApp.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public TipoIdentificacion TipoIdentificacion {get; set;}
        public string Identificacion {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public Genero Genero {get; set;}
        public string Telefono {get; set;}
        public string Correo {get; set;}
    }
}