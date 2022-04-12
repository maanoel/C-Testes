using System;
using System.IO;
using System.Linq;

namespace ConsoleTestes
{
  class Program
  {
    static void Main(string[] args)
    {
      var linhas = File.ReadLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Numeros.txt");
      int linhaAnterior = 0;
      int contadorMedidorMaiorQueAnterior = -1;

      foreach(var linha in linhas)
      {
        if(int.Parse(linha) > linhaAnterior) {
          contadorMedidorMaiorQueAnterior++;
        }

        linhaAnterior = int.Parse(linha);
      }

      Console.Write($@"O medidor ficou maior que a contagem anterior: { contadorMedidorMaiorQueAnterior} vezes." );
    }
  }
}
