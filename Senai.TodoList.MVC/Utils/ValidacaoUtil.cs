namespace Senai.TodoList.MVC.Utils {
    public class ValidacaoUtil {
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }

        public static bool ConfirmacaoEmail (string senha, string confirmaSenha) {
            if (senha.Equals (confirmaSenha)) {
                return true;
            }
            return false;
        }

        public static bool ConfirmacaoSenha (string senha, string confirmaSenha) {
            if (senha.Equals (confirmaSenha) && senha.Length > 6) {
                return true;
            }
            return false;
        }
    }
}