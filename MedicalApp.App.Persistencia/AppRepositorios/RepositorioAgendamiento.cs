using System;
using System.Collections.Generic;
using System.Linq;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public class RepositorioAgendamiento : IRepositorioAgendamiento
    {
        private readonly AppContext _appContext; //recomendable por seguridad
        public RepositorioAgendamiento(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }
        Agendamiento IRepositorioAgendamiento.AddAgendamiento(Agendamiento agendamiento)
        {
            var agendamientoAdicionado = _appContext.Agendamientos.Add(agendamiento);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return agendamientoAdicionado.Entity;
        }
        void IRepositorioAgendamiento.DeleteAgendamiento(int idAgendamiento)
        {
            var agendamientoEncontrado = _appContext.Agendamientos.FirstOrDefault(p => p.Id == idAgendamiento);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (agendamientoEncontrado == null)
                return;
            _appContext.Agendamientos.Remove(agendamientoEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
        }

        IEnumerable<Agendamiento> IRepositorioAgendamiento.GetAllAgendamientos()
        {
            return _appContext.Agendamientos;

        }

        Agendamiento IRepositorioAgendamiento.GetAgendamiento(int idAgendamiento)
        {
            return _appContext.Agendamientos.FirstOrDefault(p => p.Id == idAgendamiento);//retorna lo que encuentra
        }

        Agendamiento IRepositorioAgendamiento.UpdateAgendamiento(Agendamiento agendamiento)
        {
            var agendamientoEncontrado = _appContext.Agendamientos.FirstOrDefault(p => p.Id == agendamiento.Id);
            //No se busca el idAgendamiento, se busca el agendamiento.Id
            if (agendamientoEncontrado != null)
            {
                agendamientoEncontrado.Paciente= agendamiento.Paciente;
                agendamientoEncontrado.TipoCita= agendamiento.TipoCita;
                agendamientoEncontrado.Ciudad=agendamiento.Ciudad;
                agendamientoEncontrado.Especialidad=agendamiento.Especialidad;
                agendamientoEncontrado.Sede=agendamiento.Sede;
                agendamientoEncontrado.Medico=agendamiento.Medico;
                agendamientoEncontrado.FechaCita=agendamiento.FechaCita;
                agendamientoEncontrado.HoraCita=agendamiento.HoraCita;
                agendamientoEncontrado.Valor_Consulta=agendamiento.Valor_Consulta;
                _appContext.SaveChanges();
            }
            return agendamientoEncontrado; //retorna el agendamiento encontrado

        }

    }
}