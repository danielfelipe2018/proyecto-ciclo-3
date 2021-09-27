using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioCiudad
    {
        IEnumerable<Ciudad> GetAllCiudades(); //método que me retorna todos los pacientes
        Ciudad AddCiudad(Ciudad ciudad);
        Ciudad UpdateCiudad(Ciudad ciudad);
        void DeleteCiudad(int idCiudad);
        Ciudad GetCiudad(int idCiudad);
    }
}