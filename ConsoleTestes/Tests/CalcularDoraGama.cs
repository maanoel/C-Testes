namespace Tests
{
  internal class CalcularDoraGama : ICalculadoraSubmarino
  {
    private string[] linhas;

    public CalcularDoraGama(string[] linhas)
    {
      this.linhas = linhas;
    }

    public int Calcular()
    {
      return 22;
    }
  }
}