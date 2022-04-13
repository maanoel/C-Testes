namespace ConsoleTestes
{
  public class Submarino
  {
    private int _horizontal;
    private int _profundidade;

    public int Multiplicar() {
      return _horizontal * _profundidade;
    }

    public void AumentarHorizontal(int valor) {
       _horizontal += valor;
    }

    public void AumentarProfundidade(int valor)
    {
      _profundidade += valor;
    }

    public void DiminuirProfundidade(int valor)
    {
      _profundidade -= valor;
    }
  }
}