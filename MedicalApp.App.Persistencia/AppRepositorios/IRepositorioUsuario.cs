using System;
using System.Collections.Generic;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuario> GetAllUsuarios(); //método que me retorna todos los usuarios
        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int idUsuario);
        Usuario GetUsuario(int idUsuario);
    }
}