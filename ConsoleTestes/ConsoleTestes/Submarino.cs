namespace ConsoleTestes
{
  public class Submarino
  {
    private int _horizontal;
    private int _profundidade;
    private int _aim;

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

    public int AumentarProfundidadeMirando(int valor)
    {
      return _profundidade += _aim * valor;
    }

    public void DiminuirProfundidade(int valor)
    {
      _profundidade -= valor;
    }

    public void DiminuirMira(int valor)
    {
      _aim -= valor;
    }

    public void AumentarMira(int valor)
    {
      _aim -= valor;
    }
  }
}