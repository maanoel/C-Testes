using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
	  //O padLeft, irá colocar a string que foi dada o pad a direita e irá preencher, duas vezes com o caracter 'O' a esquerda
	  
	  //O padRight, irá colocar a string que foi dada o pad a esquerda e irá preencher, duas vezes com o caracter 'O' a direita
	  
      var teste = 1;
      var resultado = teste.ToString().PadLeft(2, '0').PadRight(4, '0');
      Console.WriteLine(resultado);    
    }
  }
}