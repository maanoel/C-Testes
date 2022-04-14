using System;
using System.Text;

namespace Tests
{
  internal class CalcularDoraGama : CalculadoraSubmarino
  {
   
    public CalcularDoraGama(string[] linhas)
    {
      this.linhas = linhas;
      this.quantidadeBitsLinha = linhas[0].Length;
    }

    public override bool ObterBitFrequencia(int indiceCaracter)
    {
      int contadorLigado = 0, contadorDesligado =0;

      for(int linha = 0; linha < linhas.Length; linha++)
      {
        var caracteresLinha = linhas[linha].ToCharArray();

        if(int.Parse(caracteresLinha[indiceCaracter].ToString()) == ligado)
          contadorLigado++;

        contadorDesligado++;
      }

      return contadorLigado > contadorDesligado;
    }
  }
}