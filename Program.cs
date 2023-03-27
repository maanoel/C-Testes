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

//KATA ENUMS

//KATAA

using CourseC_01.Entities;
using CourseC_01.Enums;

Order order = new Order
{
    Id = 1800,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
OrderStatus anotherOs = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(anotherOs);

OrderStatus anotherOfAnother;

Enum.TryParse("Shipped", out anotherOfAnother);

Console.WriteLine(anotherOfAnother);


//KATA OF ENUM

//KATAA

using CourseC_01.Entities;
using CourseC_01.Enums;

Order order = new Order
{
    Id = 1800,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
OrderStatus anotherOs = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(anotherOs);

OrderStatus anotherOfAnother;

Enum.TryParse("Shipped", out anotherOfAnother);

Console.WriteLine(anotherOfAnother);



///KATA

using CourseC_01.Entities;
using System.Text;

Client client = CreatingClient();
int quantity = CreatingItems();
OrderItem firstItem = EnterItemOne();
OrderItem secondItem = EnterItemTwo();

Order order = new Order(client); //AGGREGATE
order.AddItem(firstItem);
order.AddItem(secondItem);

Summary(order);

static Client CreatingClient()
{
    Console.WriteLine("Enter cliente data");

    string name = Console.ReadLine();
    string email = Console.ReadLine();
    DateTime birthDate = DateTime.Now;

    DateTime.TryParse(Console.ReadLine(), out birthDate);

    Client client = new Client(name, email, birthDate);

    return client;
}

static int CreatingItems()
{
    Console.WriteLine("How many items to this order?");

    int quantity = 0;

    int.TryParse(Console.ReadLine(), out quantity);

    return quantity;
}

static OrderItem EnterItemOne()
{
    Console.WriteLine("Enter #1 item data:");

    string productName = Console.ReadLine();
    double price = double.Parse(Console.ReadLine());
    int quantity = int.Parse(Console.ReadLine());

    return new OrderItem(quantity, price, new Product(productName, price));
}

static OrderItem EnterItemTwo()
{
    Console.WriteLine("Enter #2 item data:");

    string secondProductName = Console.ReadLine();
    double secondPrice = double.Parse(Console.ReadLine());
    int secondQuantity = int.Parse(Console.ReadLine());

    return new OrderItem(secondQuantity, secondPrice, new Product(secondProductName, secondPrice));
}
static void Summary(Order order)
{

    var orderItemsText = String.Join("", order.OrderItems.Select(order => order.ToString()));

    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine("ORDER SUMMARY");
    stringBuilder.AppendLine("Order Moment: " + order.Moment.ToString("dd/MM/yyyy hh:MM:ss"));
    stringBuilder.AppendLine("Order status: "+ order.Status.ToString());
    stringBuilder.AppendLine("Client: " +  order.Client.ToString());
    stringBuilder.AppendLine("OrderItems: " + orderItemsText);
    stringBuilder.AppendLine("Total Price:" + order.Total());

    Console.WriteLine(stringBuilder.ToString());
}




Console.WriteLine("Enter the number of products: ");

int productNumbers = int.Parse(Console.ReadLine());
IList<Product> products = new List<Product>();

for (int i = 1; i <= productNumbers; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.WriteLine("Common, used or imported?");

    ProductType productType = Enum.Parse<ProductType>(Console.ReadLine());

    switch (productType) {
        case ProductType.Imported:
            products.Add(GenerateProductImported());
            break;
        case ProductType.Common:
            products.Add(GenerateProductCommon());
            break;
        case ProductType.Used:
            products.Add(GenerateProductUsed());
            break;
    }
}

Console.WriteLine("PRICE TAGS:");

foreach (Product product in products) {
    Console.WriteLine(product.PriceTag());
}

Product GenerateProductImported()
{
    Console.WriteLine("Name");
    string name = Console.ReadLine();

    Console.WriteLine("Price");
    double price = double.Parse(Console.ReadLine());

    Console.WriteLine("Customs fee");
    double customsFee = double.Parse(Console.ReadLine());

    Product product = new ImportedProduct(name, price, customsFee);

    return product;
}

Product GenerateProductCommon()
{
    Console.WriteLine("Name");
    string name = Console.ReadLine();

    Console.WriteLine("Price");
    double price = double.Parse(Console.ReadLine());

    Product product = new Product(name, price);

    return product;
}


Product GenerateProductUsed()
{
    Console.WriteLine("Name");
    string name = Console.ReadLine();

    Console.WriteLine("Price");
    double price = Double.Parse(Console.ReadLine());

    Console.WriteLine("ManufactureDate");
    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

    Product product = new UsedProduct(name, price, manufactureDate);

    return product;
}

internal enum ProductType : int { 
    Common = 1,
    Used = 2,
    Imported = 3
}

internal class Product
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual string PriceTag()
    {
        return $"{Name} $ {Price}";
    }
}

internal class ImportedProduct : Product
{
    public double CustomsFee { get; private set; }
    public ImportedProduct(string name, double price, double customsFee) 
        : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public override string PriceTag()
    {
        return $"{Name} $ {TotalPrice().ToString("F2")} (Customs fee): $ {CustomsFee.ToString("F2")}";
    }

    public double TotalPrice()
    {
        return Price + CustomsFee;
    }
}

internal class UsedProduct : Product
{
    public DateTime ManufactureDate { get; private set; }
    public UsedProduct(string name, double price, DateTime manufactureDate) 
        : base(name, price)
    {
        ManufactureDate = manufactureDate;
    }

    public override string PriceTag()
    {
        return $"{Name} (used) $ {Price} (Manufacture date:) {ManufactureDate.ToString("dd/MM/yyyy")}";
    }
}




IList<Pessoa> pessoas = new List<Pessoa>();

pessoas.Add(new PessoaFisica("Vitor", 4000000, 50000));
pessoas.Add(new PessoaJuridica("Valeria", 4000000));

foreach (Pessoa pessoa in pessoas)
{
    Console.WriteLine(pessoa.CalcularImposto();
}

internal abstract class Pessoa
{
    public string Nome { get; private set; }
    public double ReandaAnual { get; private set; }

    public Pessoa(string nome, double rendaAnual)
    {
        ReandaAnual = rendaAnual;
        Nome = nome;
    }

    public abstract double CalcularImposto();
}

internal class PessoaFisica: Pessoa
{
    public double Gastos { get; set; }

    public PessoaFisica(string nome, double rendaAnual, double gastos) : base(nome, rendaAnual)
    {
        Gastos = gastos;
    }

    public override double CalcularImposto()
    {
        double taxaDescontoSaude = 0.5;
        double limiarAltaRenda = 20000;
        double descontoGatoSaude = Gastos * taxaDescontoSaude;
        double taxaImposto = ReandaAnual < limiarAltaRenda ? 0.15 : 0.25;

        return taxaImposto * ReandaAnual - descontoGatoSaude;
    }
}

internal class PessoaJuridica: Pessoa
{
    public int NumeroFuncionarios { get; set; }

    public PessoaJuridica(string nome, double rendaAnual) : base(nome, rendaAnual)
    { 
        
    }

    public override double CalcularImposto()
    {
        throw new NotImplementedException();
    }
}

		      
		      string[] text = new ElfBook().Text.Split("\r\n\r\n");
IList<Elf> elfs = new List<Elf>();

foreach (string line in text)
{
    var elf = new Elf();
    string[] lineValues = line.Split("\r\n");

    foreach (var value in lineValues)
    {
        var foodElf = new Food(int.Parse(value));
        elf.AddFoodToBag(foodElf);
    }

    elfs.Add(elf);
}

double mostCaloriesInElfsBags = new ElfBagCalculator().Calculate(elfs);

Console.WriteLine(mostCaloriesInElfsBags);

internal class Elf
{
    public IList<Food> Foods { get; private set; } = new List<Food>();

    public void AddFoodToBag(Food food)
    {
        Foods.Add(food);
    }
}

internal class Food
{
    public int Calorie { get; private set; }

    public Food(int calorie)
    {
        Calorie = calorie;
    }
}

internal class ElfBagCalculator
{
    public double Calculate(IList<Elf> calculate) 
    {
         return calculate
            .Select(elf => elf.Foods.Sum(f => f.Calorie))
            .OrderByDescending(number => number)
            .FirstOrDefault();
    }
}

internal record ElfBook 
{
    public string Text { get { return "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000"; } }
}

		      
		      
//TESTE FUNCTION SYNTAX C#
		      
		      Func<string, bool> funcao = message =>
{
    Console.WriteLine(message);
    return true;
};

funcao("teste");

Action<string> funcaoSemRetorno = message => Console.WriteLine(message);

funcaoSemRetorno("teste");


		      
		      new CalculationService().Max(new List<int> { 1 });

class CalculationService
{
    public T Max<T>(IList<T> list) where T : IComparable
    {
        T max = list[0];

        foreach (T items in list)
        {
            if (items.CompareTo(max) > 0)
                max = items;
        }

        return max;
    }
}

var list = new List<Product>();

list.Sort(CompareProduct);

Comparison<Product> teste = (p1, p2) => p1.Name.CompareTo(p2.Name);

list.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
 
static int CompareProduct(Product product, Product other)
{
    return product.Name.CompareTo(other.Name);
}
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
		      
List<object> list = new List<object>();

list.Add(new Product() { Name = "Vitor" });
list.Add(new Product() { Name = "Manoel" });

Func<object, bool> predicate = p => ((Product)p).Name != "Vitor";

IEnumerable<object> retorno = list.Where(predicate);

foreach (object item in retorno)
{
}
class Product
{
    public string Name { get; set; }
}



