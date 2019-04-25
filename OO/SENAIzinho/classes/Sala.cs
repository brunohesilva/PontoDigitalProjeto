namespace SENAIzinho {
    public class Sala {
        private string v;

        public Sala (int numeroSala, int capacidadeAtual, int capacidadeTotal) {
            this.NumeroSala = numeroSala;
            this.CapacidadeAtual = capacidadeAtual;
            this.CapacidadeTotal = capacidadeTotal;

        }
        public int NumeroSala { get; private set; }
        public int CapacidadeAtual { get; set; }
        public int CapacidadeTotal { get; }
        public Aluno[] Alunos { get; private set; }

        public Sala (int numeroSala, int capacidadeTotal) {
            this.CapacidadeTotal = capacidadeTotal;
            this.CapacidadeAtual = numeroSala;
            this.CapacidadeAtual = capacidadeTotal;
            this.Alunos = new Aluno[capacidadeTotal];
        }

        public Sala (string v) {
            this.v = v;
        }

        public bool AlocarAluno (Aluno aluno, out string mensagem) {
            if (CapacidadeAtual > 0) {
                for (int i = 0; i < Alunos.Length; i++) {
                    if (Alunos[i] == null) {
                        Alunos[i] = aluno;
                        CapacidadeAtual
                    }

                }
            }
        }

        public bool RemoverAluno (string nomeAluno, out string mensagem) {
            if (CapacidadeAtual >= 0) {
                for (int i = 0; i < Alunos.Length; i++) {
                    if (Alunos[i] != null && nomeAluno.Equals (Alunos[i])) {
                        Alunos[i] = null;
                        CapacidadeAtual++;
                        mensagem = $"Aluno {nomeAluno} removido com sucesso!";
                        return true;
                    }
                }
                mensagem = $"{nomeAluno} não foi encontrado";
                return false;
            }
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in Alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }
    }
}