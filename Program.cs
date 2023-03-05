// See https://aka.ms/new-console-template for more information

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

