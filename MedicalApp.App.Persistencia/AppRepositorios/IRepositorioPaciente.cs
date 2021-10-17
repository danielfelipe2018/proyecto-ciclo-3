using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); //método que me retorna todos los pacientes
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        public IEnumerable<Paciente> GetPacientesGenero(int genero);
        public IEnumerable<Paciente> BuscarPacientes(string nombre);
    }
}
//Interfaz: Conjunto de métodos-encabezados de los métodos- No tienen implementación