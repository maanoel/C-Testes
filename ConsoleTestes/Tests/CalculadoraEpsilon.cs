namespace Tests
{
  internal class CalculadoraEpsilon : CalculadoraSubmarino
  {
    private string[] linhas;

    public CalculadoraEpsilon(string[] linhas)
    {
      this.linhas = linhas;
    }

    public override bool ObterBitFrequencia(int indiceCaracter)
    {
      int contadorLigado = 0, contadorDesligado = 0;

      for(int linha = 0; linha < linhas.Length; linha++)
      {
        var caracteresLinha = linhas[linha].ToCharArray();

        if(int.Parse(caracteresLinha[indiceCaracter].ToString()) == ligado)
          contadorDesligado++;

        contadorLigado++;
      }

      return contadorLigado > contadorDesligado;
    }
  }
}