using System;

namespace HelloWorld
{
  class Program
  {
  	enum MeuNum { Primeiro,Segundo };
    
    static void Main(string[] args)
    {
      Console.WriteLine();
      Enum.GetName(typeof(MeuNum), 2 );
    }
  }
}