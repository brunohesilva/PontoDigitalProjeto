using System;
using System.Collections.Generic;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.Repositorio
{
    public class UsuarioRepositorio
    {
        public List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count +1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

            return usuario;
        }
        
        public UsuarioViewModel BuscarUsuario(string email, string senha)
{
            foreach (var item in listaDeUsuarios)
            {
                if (item.Email.Equals(email) && item.Senha.Equals(senha)) 
                {
                    return item;
                }

            }
                return null;
        }

        public List<UsuarioViewModel> Listar(){
            return listaDeUsuarios;
        }
    }
}