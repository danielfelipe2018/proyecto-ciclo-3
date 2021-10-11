using System;
using System.ComponentModel.DataAnnotations;
namespace MedicalApp.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        [Display (Name="Tipo de Identificación")]
        [Required(ErrorMessage="Dato requerido")]
        public TipoIdentificacion TipoIdentificacion {get; set;}
        [Required(ErrorMessage="Dato requerido")]
        public string Identificacion {get; set;}
        [Required(ErrorMessage="Nombre requerido")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre {get; set;}
        [Required(ErrorMessage="Apellido requerido")]
        [MaxLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Apellido {get; set;}
        [Required(ErrorMessage="Género requerido")]
        public Genero Genero {get; set;}
        [Required(ErrorMessage="Teléfono requerido")]
        public string Telefono {get; set;}
        [Display (Name="Correo electrónico")]
        [Required(ErrorMessage="Correo electrónico requerido")]
        public string Correo {get; set;}
    }
}