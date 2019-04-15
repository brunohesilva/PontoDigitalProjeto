using System; 

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao OnurRegistros!");
            bool sair = false;
            Aluno[] alunos = new Aluno[4];
            int passageirosCadastrados = 0;
            

            do {
            
            Aluno aluno1 = new Aluno();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Cadastrar Sala");
            Console.WriteLine("3 - Alocar Aluno");
            Console.WriteLine("4 - Remover Aluno");
            Console.WriteLine("5 - Verificar Salas");
            Console.WriteLine("6 - Verificar Alunos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------------------");
            int codigo = int.Parse (Console.ReadLine ());
            
            System.Console.WriteLine ("Digite o nome do Aluno");
            aluno1.nome = Console.ReadLine();
            System.Console.WriteLine ("Digite a Data de Nascimento");
            aluno1.dataNascimento = Console.ReadLine();
            } while (!sair);
        }
    }
}
