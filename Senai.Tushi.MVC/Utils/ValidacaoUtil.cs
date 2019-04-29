using System;

namespace Senai.Tushi.MVC.Utils
{
    public static class ValidacaoUtil
    {
        /// <sumary>Retorna true caso o email possua @ e .static e false se não possui</sumary> \\\
        public static bool ValidarEmail(string email){
            if (email.Contains("@") && email.Contains(".")){
                return true;
            }
            return false;
        }

        /// <summary>Retorna true caso a senhas sejam iguais ou false caso cotrario</summary>
        public static bool ConfirmacaoEmail(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha)){
                return true;
            }
            return false;
        }

        public static bool ConfirmacaoSenha(string senha, string confirmaSenha){
            if (senha.Equals(confirmaSenha) && senha.Length > 6){
                return true;
            }
            return false;
        }
    }
}