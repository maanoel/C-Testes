﻿// See https://aka.ms/new-console-template for more information

sbyte n1 = 127;

n1++;

//Se uma variável passar os valores permitidos o retorno será o valor oposto do tipo de dados
//No caso do sbyte seu valor oposto é -128, que será retornado sempre que passar do valor máximo
// que é 127

Console.WriteLine(n1);

// See https://aka.ms/new-console-template for more information

using System.Globalization;

/**********CODE KATAAAAAAAAAAA********/

/**************************************/

sbyte n1 = 127;

n1++;

//Se uma variável passar os valores permitidos o retorno será o valor oposto do tipo de dados
//No caso do sbyte seu valor oposto é -128, que será retornado sempre que passar do valor máximo
// que é 127

char letra = '\u0040';

float f = 4.5f;
double d = 4.0;

double saldo = 100.5080;

Console.WriteLine(saldo.ToString("F4"));
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


object obj1 = "Alex brown";
obj1 = f as Object;

Console.WriteLine(d.ToString("2F", CultureInfo.InvariantCulture));
Console.WriteLine(int.MinValue);
Console.WriteLine(float.MinValue);
Console.WriteLine(decimal.MinValue);
Console.WriteLine(decimal.MaxValue);
Console.WriteLine(letra);
Console.WriteLine(n1);
Console.Write(n1);

double number = 1234;

number.ToString("C");

string nome = "fulano";

int idade = 32;


// PlaceHolder
Console.WriteLine("{0} tem um {1} anos e tem saldo igual a {2:F2}",
    nome,
    idade,
    saldo
    );



//****************** CODE KATAAA /*************************

int a, b, c;

a = 10;
b = 30;
c = 30;

double p = (a + b + c) / 2.0;

double area = Math.Sqrt(p * (p-a) * (p-b) * (p-c));

Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));


// See https://aka.ms/new-console-template for more information

using System.Globalization;


Console.WriteLine(Math.Sqrt(2));


//****************** CODE KATAAA /*************************



var triangulo = new Triangulo(20, 30, 40);
double area = triangulo.CalcularArea();

Console.WriteLine(triangulo);
Console.WriteLine(area);

class Triangulo
{
    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }

    public double LadoA { get; private set; }
    public double LadoB { get; private set; }
    public double LadoC { get; private set; }

    public double CalcularArea()
    {
        //Fórmula de Heron
        double p = (LadoA + LadoB + LadoC) / 2.0;
        return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
    }

    public override string ToString()
    {
        return $"Lado A {LadoA} Lado B {LadoB} {LadoC}";
    }
}

class Produto
{
    public string Nome { get; private set; }
    public int Quantidade { get; private set; }
    public int Preco { get; private set; }

    public Produto(string nome, int quantidade, int preco)
    {
        Nome = nome;
        Quantidade = quantidade;
        Preco = preco;
    }

    public void RemoverProduto(int quantidade) 
    {
        Quantidade -= quantidade;
    }

    public void Atualizar() 
    {
        Quantidade++;
    }
}

/* CODING KATA */


//REF precisa ser inicializada
//OUT não precisa ser inicializado

int a = 10;
int retorno = 10;

new Calculadora().TesteTres(ref a, out retorno);

public class Calculadora
{
    public double Soma(params int[] numeros)
    {
        double soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        return soma;
    }

    public void Teste(params int[] parametros)
    { 
        
    }

    public void TesteTres(ref int teste, out int retorno) {
        retorno = teste * 3;
    }
}



/***************/


/* CODING KATA */


using System.Collections;

IEnumerable<Pessoa> hashSet = new HashSet<Pessoa>();
List<Pessoa> lista = new List<Pessoa>();
Hashtable listPessoa = new Hashtable();





lista.Find(Test);

var teste = lista.Find(l => l.Nome == "Vitor");

lista.RemoveRange(1, 1);

//PREDICATE

static bool Test(Pessoa pessoa)
{
    if (pessoa.Nome == "Vitor") return true;

    return false;
}

public class Pessoa
{ 
    public string Nome { get; private set ; }
}



double[,] matriz = new double[2, 3];

Console.WriteLine(matriz.Length);
Console.WriteLine(matriz.Rank);
Console.WriteLine(matriz.GetLength(0));
Console.WriteLine(matriz.GetLength(1));


matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[0, 2] = 3;

Console.WriteLine(matriz[0,2]);




int[,] matrizDeIneteiros = new int[5, 5];

matrizDeIneteiros[0, 1] = 5;

Console.WriteLine(matrizDeIneteiros[0,1].ToString());


Dictionary<string, List<string>> dicionarioDeNumeros = new Dictionary<string, List<string>>();


dicionarioDeNumeros["Vitor"] = new List<string> { "71991520478", "32116146" };


foreach (KeyValuePair<string, List<string>> item in dicionarioDeNumeros)
{
	foreach (string numero in item.Value)
	{
        Console.WriteLine(numero);
    }
}


string original = "abcde FGHIJ ABC abc DEFG";

string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();
int n1 = original.IndexOf("bcde");
int n2 = original.LastIndexOf("bc");
string s4 = original.Substring(3);
string s5 = original.Substring(0, 4);
string s6 = original.Replace(" ", "-");

bool testeVazio = string.IsNullOrEmpty(s1);
bool testeStringComEspacos = string.IsNullOrWhiteSpace(s2);

string[] testeSplit = s1.Split(" ");

Console.WriteLine(testeSplit[0]);




//DateTime é um tipo valor??

// 1 tick - 100 nanosegundos

using System.Globalization;
/// CODE KATAAA
DateTime d1 = DateTime.Now;

Console.WriteLine(d1.Ticks);
Console.WriteLine(new DateTime(2000, 01, 01));
Console.WriteLine(new DateTime(2000, 01, 01, 20, 20, 20));
Console.WriteLine(new DateTime(2000, 01,01,20,20, 20, 20, DateTimeKind.Utc));
Console.WriteLine(DateTime.Today);
Console.WriteLine(DateTime.UtcNow);

DateTime parseado = DateTime.Parse(d1.ToString());

Console.WriteLine(DateTime.Parse("2000-08-15 13:05:58"));
DateTime d3 = DateTime.Parse("15/08/2000 13:00:00");

Console.WriteLine(d3);

DateTime exact = DateTime.ParseExact("2000-08-15 13:58:59", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(exact);

TimeSpan s1 = new TimeSpan(12, 07, 30);

Console.WriteLine(s1);
Console.WriteLine(s1.Ticks);

Console.WriteLine(new TimeSpan());
Console.WriteLine(new TimeSpan(900000000L));

Console.WriteLine(TimeSpan.FromDays(1));
Console.WriteLine(TimeSpan.FromSeconds(1.4));
Console.WriteLine(TimeSpan.Zero);

Console.WriteLine(new DateTime(TimeSpan.FromDays(1).Ticks));

DateTime data = DateTime.Now;
DateTime dataDois = new DateTime(2023, 3, 8);
Console.WriteLine(data);
Console.WriteLine(data.Date);
Console.WriteLine(data.Year);
Console.WriteLine(data.TimeOfDay);

Console.WriteLine(data.ToUniversalTime());
Console.WriteLine(data.ToLongDateString());
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
Console.WriteLine(data.ToString("yyyy-MM-dd HH:mm:ss.fff"));
Console.WriteLine(data.AddDays(1));
Console.WriteLine(data.DayOfWeek);
Console.WriteLine(data.AddDays(7));

TimeSpan diferenca = data.Subtract(dataDois);

Console.WriteLine(diferenca);

Console.WriteLine(new DateTime(diferenca.Ticks));


var dataAtual = DateTime.Now;
var dataNascimento = new DateTime(1989, 08, 29);

TimeSpan diferenca = dataAtual - dataNascimento;

Console.WriteLine(diferenca.Days / 365);
Console.WriteLine(diferenca.Hours);
Console.WriteLine(diferenca.TotalDays);


TimeSpan t1 = new TimeSpan(1, 30, 10);
TimeSpan t2 = new TimeSpan(0, 10, 5);
TimeSpan soma = t1.Add(t2);
TimeSpan diff = t1.Subtract(t2);

Console.WriteLine(soma);
Console.WriteLine(diff);


var data = DateTime.Now;

//data.Add(soma); Aqui não funciona pq não modifica a instÂncia

data = data.Add(soma); // Aqui funciona pq retorno a nova instância


Console.WriteLine(data.ToString());

TimeSpan multi = t2.Multiply(2);

Console.WriteLine(multi);


using System.ComponentModel.DataAnnotations;

Queue<Pessoa> filaDePessoas = new Queue<Pessoa>();

filaDePessoas.Enqueue(new Pessoa("Vitor Brito"));
filaDePessoas.Enqueue(new Pessoa("Nadine Brito"));
filaDePessoas.Enqueue(new Pessoa("Felipe Figueiredo"));

var primeiroAtendimento = filaDePessoas.Dequeue();
var segundoAtendimento = filaDePessoas.Dequeue();
var terceiroAtendimento = filaDePessoas.Dequeue();

Console.WriteLine($"A ordem dos atendimentos foram as seguintes: {primeiroAtendimento.Nome} - {segundoAtendimento.Nome} - {terceiroAtendimento.Nome}");

public class Pessoa
{
    public string Nome { get; private set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Queue<T> where T : class
{
    public int Count { get; private set; }
    public int LowestCount { get; private set; }
    public IList<T> Items { get; private set; }

    public Queue()
    {
        Items = new List<T>();
    }

    public void Enqueue(T item)
    {
        Items.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty()) return default;

        var firstItem = Items.First();
        Items.Remove(firstItem);

        return firstItem;
    }

    public T Peek()
    {
        if (IsEmpty()) return default;

        return Items.First();
    }

    public bool IsEmpty()
    {
        return !Items.Any();
    }

    public int Size()
    {
        return Items.Count;
    }
}


DateTime t1 = new DateTime(2023, 03, 09, 13, 05, 05, DateTimeKind.Utc);

Console.WriteLine(t1);
Console.WriteLine(t1.ToLocalTime());
Console.WriteLine(t1.ToUniversalTime());

var dataTeste = DateTime.Now;

Console.WriteLine(dataTeste.Kind);
Console.WriteLine(dataTeste.ToUniversalTime());
Console.WriteLine(dataTeste.Kind);


DateTime t1 = DateTime.Parse("2000-08-15 13:05:58");
DateTime t2 = DateTime.Parse("2000-08-15T13:05:58Z"); //ISO 8601

Console.WriteLine(t1);
Console.WriteLine(t2);
