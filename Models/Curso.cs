using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome{ get; set;}
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
                return Alunos.Remove(aluno);
                
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"ALunos do curso de: {Nome}");

            
            for(int cont = 0; cont < Alunos.Count; cont++)
            {
                //string texto = "Nª" + cont + " - " + Alunos[cont].NomeCompleto;
                String texto = $"Nª {cont + 1} - {Alunos[cont].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
        }
    }
}