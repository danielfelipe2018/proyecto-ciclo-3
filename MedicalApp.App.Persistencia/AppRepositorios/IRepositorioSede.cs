using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes(); //método que me retorna todos los pacientes
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);
        Ciudad AsignarCiudad(int idSede,int idCiudad);
    }
}