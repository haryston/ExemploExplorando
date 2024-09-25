using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool sucesso, string[] linhas, int quantidadeLinhas)  LerArquivos(String caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}