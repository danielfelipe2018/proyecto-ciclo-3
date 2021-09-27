using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos(); //método que me retorna todos los pacientes
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico GetMedico(int idMedico);
    }
}