using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioAgendamiento
    {
        IEnumerable<Agendamiento> GetAllAgendamientos(); //método que me retorna todos los agendamientos
        Agendamiento AddAgendamiento(Agendamiento agendamiento);
        Agendamiento UpdateAgendamiento(Agendamiento agendamiento);
        void DeleteAgendamiento(int idAgendamiento);
        Agendamiento GetAgendamiento(int idAgendamiento);
        Paciente AsignarPaciente(int idAgendamiento,int idPaciente);
        Medico AsignarMedico(int idAgendamiento,int idMedico);
    }
}