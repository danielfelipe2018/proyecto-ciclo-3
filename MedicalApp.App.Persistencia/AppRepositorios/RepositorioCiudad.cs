using System;
using System.Collections.Generic;
using System.Linq;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public class RepositorioCiudad : IRepositorioCiudad
    {
        private readonly AppContext _appContext; //recomendable por seguridad
        public RepositorioCiudad(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }
        Ciudad IRepositorioCiudad.AddCiudad(Ciudad ciudad)
        {
            var ciudadAdicionado = _appContext.Ciudades.Add(ciudad);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return ciudadAdicionado.Entity;
        }

        void IRepositorioCiudad.DeleteCiudad(int idCiudad)
        {
            var ciudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == idCiudad);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (ciudadEncontrado == null)
                return;
            _appContext.Ciudades.Remove(ciudadEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
        }

        IEnumerable<Ciudad> IRepositorioCiudad.GetAllCiudades()
        {
            return _appContext.Ciudades;

        }

        Ciudad IRepositorioCiudad.GetCiudad(int idCiudad)
        {
            return _appContext.Ciudades.FirstOrDefault(p => p.Id == idCiudad);//retorna lo que encuentra
        }

        Ciudad IRepositorioCiudad.UpdateCiudad(Ciudad ciudad)
        {
            var ciudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == ciudad.Id);
            //No se busca el idCiudad, se busca el ciudad.Id
            if (ciudadEncontrado != null)
            {
                ciudadEncontrado.NombreCiudad= ciudad.NombreCiudad;
                _appContext.SaveChanges();
            }
            return ciudadEncontrado; //retorna la ciudad encontrada

        }
    }
}