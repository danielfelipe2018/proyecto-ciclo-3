using System;
using System.Collections.Generic;
using System.Linq;
using MedicalApp.App.Dominio;

namespace MedicalApp.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext; //recomendable por seguridad
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext; //Necesitamos definir un contexto
        }
        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioAdicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int idUsuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if (usuarioEncontrado == null)
                return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
        {
            return _appContext.Usuarios;

        }

        Usuario IRepositorioUsuario.GetUsuario(int idUsuario)
        {
            return _appContext.Usuarios.FirstOrDefault(p => p.Id == idUsuario);//retorna lo que encuentra
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == usuario.Id);
            //No se busca el idCiudad, se busca el ciudad.Id
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Paciente= usuario.Paciente;
                usuarioEncontrado.NombreUsuario=usuario.NombreUsuario;
                usuarioEncontrado.Password=usuario.Password;
                _appContext.SaveChanges();
            }
            return usuarioEncontrado; //retorna el usuario encontrado

        }
    }
}