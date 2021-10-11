using System.ComponentModel.DataAnnotations;
namespace MedicalApp.App.Dominio
{
    public class Sede
    {
        public int Id {get; set;}
        public Ciudad Ciudad {get; set;}
        [Display (Name="Nombre de la sede")]
        [Required(ErrorMessage="Dato requerido")]
        public string NombreSede {get; set;}
        [Required(ErrorMessage="Dato requerido")]
        public string Direccion {get; set;}
    }
}