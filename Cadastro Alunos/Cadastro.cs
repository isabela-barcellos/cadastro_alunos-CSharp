using System.Collections.ObjectModel;

namespace Cadastro_Alunos
{
    public class Cadastro
    {
        private static Cadastro _instance;
        public static Cadastro Instance => _instance ?? (_instance = new Cadastro());
        private Cadastro()
        {
            Alunos = new ObservableCollection<Aluno>();
            contadorMatricula = 1;
        }
        public ObservableCollection<Aluno> Alunos { get; private set; }
        private int contadorMatricula;
        public void Cadastrar(string nome, int matricula, double nota1, double nota2)
        {
            var aluno = new Aluno(nome, matricula);
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            Alunos.Add(aluno);
            contadorMatricula++;
        }
        public void CadastrarAutoMatricula(string nome, double nota1, double nota2)
        {
            int matricula = contadorMatricula;
            Cadastrar(nome, matricula, nota1, nota2);
        }
    }
}
