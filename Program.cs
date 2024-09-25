using ExemploExplorando.Models;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Newtonsoft.Json;



string ConteudoArquivo = File.ReadAllText("Arquivos/Vendas.Json");

List<Venda> ListaVenda = JsonConvert.DeserializeObject<List<Venda>>(ConteudoArquivo); 

foreach(Venda venda in ListaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}," +
                      $"  Preco: {venda.Valor}, Data Atual: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
                        
}

































// //CRIANDO UMA ARQUIVO JSON

// DateTime DataAtual = DateTime.Now;
// List<Venda> ListaVenda = new List<Venda>();

// Venda v1 = new Venda (1, "chinelo", 10.0M, DataAtual );
// Venda v2 = new Venda (2, "computador", 15.0M, DataAtual);
// Venda v3 = new Venda (3, "software", 17.0M, DataAtual);

// ListaVenda.Add(v1);
// ListaVenda.Add(v2);
// ListaVenda.Add(v3);

// string serializado = JsonConvert.SerializeObject(ListaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.Json", serializado);

// Console.WriteLine(serializado);


















// IF TERMINARIO 
// int num = 10;
// bool mero =false;
// mero = num % 2 == 0;

// Console.WriteLine($"o numero {num} é " + (mero ? "par" : "ímpar"));


// if(num % 2 == 0)
// {
//     Console.WriteLine($"{num} é par");
// }
// else{
//     Console.WriteLine($"{num} é ímpar");
// }

















// Pessoa p1 = new Pessoa("harystonn", "daniel");
 
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


























// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivos("Arquivo/LeituraArquivo");

// if(sucesso)
// {
//         Console.WriteLine("Quantidade de linhas" + quantidadeLinhas);
//         foreach(string linha in linhas){
//             Console.WriteLine(linha);
//         }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }



















// TUPLAS
// (int, String, String, decimal) tupla  = (1, "haryston", "Daniel", 1.91M);


// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");























// DICTIONARY
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "SAO PAULO");
// estados.Add("GO", "GOIAS");
// estados.Add("TO", "TOCANTINS");
// estados.Add("MA", "MARANHAO");


// Console.WriteLine(estados["GO"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("TO");

// Console.WriteLine("-----------");

// estados["SP"] = "SÃO PAULO = VALOR ALTERADO";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// Console.WriteLine($"VERIFIQUE O ELEMENTO: {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existe {chave}");
// }




// string chave = "BA2";
// Console.WriteLine($"VERIFIQUE O ELEMENTO: {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"valor existente: {chave}");
// }
// else{
//     Console.WriteLine($"Valor não existe. pode adicionar a chve {chave}");
// }


//Console.WriteLine(estados["GO"]);










//PILHA
// Stack<int> pilha = new Stack<int>();

// pilha.Push(10);
// pilha.Push(2);
// pilha.Push(9);
// pilha.Push(8);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"removendo elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }








//FILA

// Queue<int> fila = new Queue<int>();


// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(9);
// fila.Enqueue(15);

// foreach(int item in fila){
//     Console.WriteLine(item);
// }



// Console.WriteLine($"REMOVENDO ELEMENTOS DA FILA: {fila.Dequeue()}");

// fila.Enqueue(5);
// foreach(int item in fila){
//     Console.WriteLine(item);
// }









//new ExecaoExemplo().metodo1();












// //TRATANDO ECEÇÃO COM TRYCATH
// try {
// string[] Linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");

// foreach(string linha in Linhas)
// {
//     Console.WriteLine(linha);
// }

// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado." + ex.Message);
// }
// catch(DirectoryNotFoundException ex){
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado . {ex.Message}");
// }

// catch(Exception ex)
// {
//     Console.WriteLine($"ocorreu um exceção genérica. {ex.Message}");
// }
// finally
// {
// Console.WriteLine("Chegou aqui");
// }














































//DateTime data = DateTime.Parse("17/12/2022 12:56");


//cONVERTER UMA STRING COM TRYPARSE
// string datastring = "2024-04-10 10:00";

// bool sucesso = DateTime.TryParseExact(datastring,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None,
//                         out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Convertida com sucesso! Data: {data}");

// }else{
//     Console.WriteLine($"{datastring} não é válida");
// }

// Console.WriteLine(data);






























// CultureInfo.DefaultThreadCurrentCulture= new CultureInfo("pt-BR");
// decimal valorMonetario = 1450.20M;

// Console.WriteLine($"{valorMonetario:C}");

// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Console.WriteLine(valorMonetario.ToString("C5"));

// double porcentagem = .1023;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));











// Pessoa p1 = new Pessoa("HARYSTON", "DANIEL");
// Pessoa p2 = new Pessoa("HAYLA", "MARTINS");


// Curso CursoIngles = new Curso();
// CursoIngles.Nome = "Ingles";
// CursoIngles.Alunos = new List<Pessoa>();


// CursoIngles.AdicionarAluno(p1);
// CursoIngles.AdicionarAluno(p2);
// CursoIngles.ListarAlunos();












// Pessoa p1 = new Pessoa();

// p1.Nome = "haryston";
// p1.Idade = 10;
// p1.Sobrenome = "Daniel";
// p1.Apresentar();