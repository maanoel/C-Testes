namespace Tests
{
  internal class CalculadoraEpsilon : ICalculadoraSubmarino
  {
    private string[] linhas;

    public CalculadoraEpsilon(string[] linhas)
    {
      this.linhas = linhas;
    }

    public int Calcular()
    {
      return 9;
    }
  }
}