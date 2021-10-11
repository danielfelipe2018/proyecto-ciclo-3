using System.ComponentModel.DataAnnotations;
namespace MedicalApp.App.Dominio
{
    public class Ciudad
    {
        public int Id {get; set;}
        [Display (Name="Nombre de la ciudad")]
        [Required(ErrorMessage="Dato requerido")]
        public string NombreCiudad {get; set;}
    }
}