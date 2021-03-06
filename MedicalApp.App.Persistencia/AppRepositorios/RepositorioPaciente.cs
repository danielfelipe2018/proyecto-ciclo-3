using System;
using System.Collections.Generic;
using System.Linq;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext(); //recomendable por seguridad
//        public RepositorioPaciente(AppContext appContext)
//        {
//            _appContext = appContext; //Necesitamos definir un contexto
//        }
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return pacienteAdicionado.Entity;
        }

        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
        }

        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;

        }

        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);//retorna lo que encuentra
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            //No se busca el idPaciente, se busca el paciente.Id
            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.TipoIdentificacion= paciente.TipoIdentificacion;
                pacienteEncontrado.Identificacion=paciente.Identificacion;
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellido = paciente.Apellido;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Correo=paciente.Correo;
                pacienteEncontrado.TipoPaciente = paciente.TipoPaciente;
                pacienteEncontrado.Convenio = paciente.Convenio;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado; //retorna el paciente encontrado

        }
        
        public IEnumerable<Paciente> GetPacientesGenero(int genero)
        {
            return _appContext.Pacientes
                    .Where (p=>p.Genero==(Genero)genero)
                    .ToList();
        }

        public IEnumerable<Paciente> BuscarPacientes(string nombre)
        {
            return _appContext.Pacientes
                    .Where (p=>p.Nombre.Contains(nombre));
        }
    }


}
// implementa la interfaz 