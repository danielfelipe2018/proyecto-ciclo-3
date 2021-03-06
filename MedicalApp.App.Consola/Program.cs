using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;
using MedicalApp.App.Persistencia;

namespace MedicalApp.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente(1);
            //AddMedico();
            MostrarPacientes();
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                TipoIdentificacion=TipoIdentificacion.Cedula,
                Identificacion="1000111222",
                Nombre = "Jose Fernando",
                Apellido = "Ordoñez",
                Genero = Genero.Masculino,
                Telefono = "3152152014",
                Correo = "correopaciente@correo.com",
                TipoPaciente=TipoPaciente.Particular,
                Convenio=Convenio.Si
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: " + paciente.Nombre + " " + paciente.Apellido + "  Género: " + paciente.Genero);
        }

        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine("Nombre: " + paciente.Nombre + " " + paciente.Apellido + "  Género: " + paciente.Genero);
            }
        }

        private static void AddMedico()
        {
            var medico = new Medico
            {
                TipoIdentificacion=TipoIdentificacion.Cedula,
                Identificacion="1000111222",
                Nombre = "Pepito",
                Apellido = "Perez",
                Genero = Genero.Masculino,
                Telefono = "3152152014",
                Correo = "correopaciente@correo.com",
                Especialidad=Especialidad.Medicina_General
            };
            _repoMedico.AddMedico(medico);
        }
        
    }
}