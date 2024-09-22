using ExemploExplorando.Models;
using System.Globalization;


//DateTime data = DateTime.Parse("17/12/2022 12:56");



//cONVERTER UMA STRING COM TRYPARSE 
string datastring = "2024-04-10 10:00";

DateTime.TryParseExact(datastring,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data);

Console.WriteLine(data);






























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