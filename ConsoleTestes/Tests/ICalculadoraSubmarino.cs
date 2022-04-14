using System;

namespace Tests
{
  public abstract class CalculadoraSubmarino
  {
    protected string[] linhas;
    protected string energiConsumida;
    protected int quantidadeBitsLinha = 0;
    protected const int ligado = 1;
    protected const int desligado = 0;

    protected CalculadoraSubmarino(string [] linhas)
    {
      this.quantidadeBitsLinha = linhas[0].Length;
      this.linhas = linhas;
    }

    public abstract bool ObterBitFrequencia(int indiceCaracter);

    public int Calcular()
    {
      energiConsumida = "";

      for(int indiceCaracter = 0; indiceCaracter < quantidadeBitsLinha; indiceCaracter++)
      {
        CalcularBitFrequencia(indiceCaracter);
      }

      return Convert.ToInt32(energiConsumida, 2);
    }

    private void CalcularBitFrequencia(int indiceCaracter)
    {
      var bitLigado = ObterBitFrequencia(indiceCaracter);

      AdicionarBitEnergiaConsumida(bitLigado);
    }

    protected void AdicionarBitEnergiaConsumida(bool bitLigado)
    {
      energiConsumida += bitLigado ? ligado.ToString() : desligado.ToString();
    }
  }
}