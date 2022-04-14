using System;
using System.Text;

namespace Tests
{
  internal class CalcularDoraGama : ICalculadoraSubmarino
  {
    private string[] linhas;
    private string energiConsumida;
    private int quantidadeBitsLinha = 0;

    const int ligado = 1;
    const int desligado = 0; 

    public CalcularDoraGama(string[] linhas)
    {
      this.linhas = linhas;
      this.quantidadeBitsLinha = linhas[0].Length;
    }

    public int Calcular()
    {
      return ObterTaxaGama();
    }

    private int ObterTaxaGama()
    {
      for(int indiceCaracterer = 0; indiceCaracterer < quantidadeBitsLinha; indiceCaracterer++)
      {
        ObterBitMaiorFrequencia(indiceCaracterer);
      }

      return Convert.ToInt32(energiConsumida, 2);
    }

    private void ObterBitMaiorFrequencia(int indiceCaracterer)
    {
      bool bitMaiorFrequencia;
      var contadorLigado = 0;
      var contadorDesligado = 0;

      for(int linha = 0; linha < linhas.Length; linha++)
      {
        var caracteresLinha = linhas[linha].ToCharArray();

        if(int.Parse(caracteresLinha[indiceCaracterer].ToString()) == ligado)
          contadorLigado++;

        contadorDesligado++;
      }

      bitMaiorFrequencia = contadorLigado > contadorDesligado;
      energiConsumida += bitMaiorFrequencia ? ligado.ToString() : desligado.ToString();

      return bitMaiorFrequencia;
    }
  }
}