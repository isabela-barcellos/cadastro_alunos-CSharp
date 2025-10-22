using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Alunos
{
    public class Aluno
    {
        public Aluno(string nome,int matricula)
        {
            this.Nome = nome;
            this.Matricula = matricula;
        }
        public string Nome { get; set; } 
        public int Matricula { get; set; } 
        public double Nota1 { get; set; } 
        public double Nota2 { get; set; } 
        public double Media => (Nota1 + Nota2) / 2;

    }
}
