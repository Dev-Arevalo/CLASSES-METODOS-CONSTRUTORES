using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace METODOS.CURSOS
{
    public class Pessoa
    {
        //CONSTRUTOR QUE SERVE COMO VALOR PADRÃO PARA A CLASSE//
        public Pessoa()
        {

        }

        //METODO CONSTRUTUR QUE RECEBE NOME//
        public Pessoa(string nome)
        {
            Nome = nome;

        }

        //IMPLEMENTANDO A "CLASSE"//

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        public void AdicionarAluno(Pessoa aluno)//assinatura de um metodo, menos o "PUBLIC"//
        {
            Alunos.Add(aluno);
            
        }

        public int QuantidadeDeAlunosMatriculados()//metodo para ver a quantidade de alunos matriculados//
        {
            int quantidade = Alunos.Count;// "RETURN" deve ser usado em todos os metodos de retorno//
            return quantidade;

        }

        // IMPLEMENTANDO O METODO REMOVER NA LISTA//
        public bool RemoverAluno(Pessoa aluno)// adicionar metodo booleano para o retorno da lista//
        {
            return Alunos.Remove(aluno);
           
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno  in Alunos)
            {
                Console.WriteLine(aluno.Nome);
                
            }
        
        }
        
    }
}