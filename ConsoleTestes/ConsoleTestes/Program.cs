using System;
using System.IO;
using System.Linq;

namespace ConsoleTestes
{
  class Program
  {
    static void Main(string[] args)
    {
      MedidorComGrupoDeTres();
      Medidor();
    }

    private static void Medidor() {

      var linhas = File.ReadLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Numeros.txt");
      int linhaAnterior = 0;
      int contadorMedidorMaiorQueAnterior = -1;

      foreach(var linha in linhas)
      {
        if(int.Parse(linha) > linhaAnterior)
        {
          contadorMedidorMaiorQueAnterior++;
        }

        linhaAnterior = int.Parse(linha);
      }

      Console.Write($@"O medidor ficou maior que a contagem anterior: { contadorMedidorMaiorQueAnterior} vezes.");
    }

    private static void MedidorComGrupoDeTres() { 
      var linhas = File.ReadAllLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Numeros.txt");
      int contadorMedidorMaiorQueAnterior = -1;
      int somaGrupoAtual = 0;
      int somaGrupoAnterior = 0;

      for(int i = 0; i < linhas.Length; i++)
      {
        if(i >= 2) {
          somaGrupoAtual = int.Parse(linhas[i]) + int.Parse(linhas[i - 1]) + int.Parse(linhas[i - 2]);

          if(somaGrupoAtual > somaGrupoAnterior) {
            contadorMedidorMaiorQueAnterior++;
          }

          somaGrupoAnterior = somaGrupoAtual;
        }
      }

      Console.Write($@"O medidor ficou maior que a contagem anterior: { contadorMedidorMaiorQueAnterior} vezes.");
    }
  }
}
