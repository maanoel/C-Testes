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
