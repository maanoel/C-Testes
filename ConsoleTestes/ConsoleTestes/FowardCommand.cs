using System;

namespace ConsoleTestes
{
  public class FowardCommand : IComando
  {
    public Submarino Submarino { get; private set; }
    public int Valor { get; private set; }

    public FowardCommand(Submarino submarino, int valor)
    {
      Submarino = submarino;
      Valor = valor;
    }

    public void Executar()
    {
      Submarino.AumentarHorizontal(Valor);
    }

  }
}
