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
      return ObterTaxa();
    }

    private int ObterTaxa()
    {
      return CalcularEnergiaConsumida();
    }

    private int CalcularEnergiaConsumida()
    {
      for(int indiceCaracterer = 0; indiceCaracterer < quantidadeBitsLinha; indiceCaracterer++)
      {
        CalcularBitFrequencia(indiceCaracterer);
      }

      return Convert.ToInt32(energiConsumida, 2);
    }

    private void CalcularBitFrequencia(int indiceCaracterer)
    {
      var bitLigado = ObterBitMaiorFrequencia(indiceCaracterer);

      AdicionarBitEnergiaConsumida(bitLigado);
    }

    private bool ObterBitMaiorFrequencia(int indiceCaracterer)
    {
      int contadorLigado = 0, contadorDesligado =0;

      for(int linha = 0; linha < linhas.Length; linha++)
      {
        var caracteresLinha = linhas[linha].ToCharArray();

        if(int.Parse(caracteresLinha[indiceCaracterer].ToString()) == ligado)
          contadorLigado++;

        contadorDesligado++;
      }

      return contadorLigado > contadorDesligado;
    }

    private void AdicionarBitEnergiaConsumida(bool bitLigado)
    {
      energiConsumida += bitLigado ? ligado.ToString() : desligado.ToString();
    }
  }
}