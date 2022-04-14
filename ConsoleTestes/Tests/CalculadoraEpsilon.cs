namespace Tests
{
  internal class CalculadoraEpsilon : CalculadoraSubmarino
  {

    public CalculadoraEpsilon(string[] linhas): base(linhas)
    {
      
    }

    public override bool ObterBitFrequencia(int indiceCaracter)
    {
      int contadorLigado = 0, contadorDesligado = 0;

      for(int linha = 0; linha < linhas.Length; linha++)
      {
        var caracteresLinha = linhas[linha].ToCharArray();

        if(int.Parse(caracteresLinha[indiceCaracter].ToString()) == desligado)
          contadorDesligado++;
        else
          contadorLigado++;
      }

      return contadorDesligado > contadorLigado;
    }
  }
}