using System;
using System.Collections.Generic;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC.Repositorio
{
    public class UsuarioRepositorio
    {
        List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel>();

        /// <summary>Método responsavel por armazenar um usário</summary>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.Id = listaDeUsuarios.Count +1;
            usuario.DataCriacao = DateTime.Now;

            listaDeUsuarios.Add(usuario);

            return usuario;
        }
        /// <summary>Retorna lista de usuários</summary>
        public List<UsuarioViewModel> Listar(){
            return listaDeUsuarios;
        }
        /// <summary>Verifica se o usuário é válido</summary>
        /// <parm name="email">Email do Usuário</parm>
        /// <parm naem="senah">Senah do Usuário</parm>
        /// <returns>Retorna o usuário caso ele seja encontrado ou null caso não exista</returns>  
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
    }
}