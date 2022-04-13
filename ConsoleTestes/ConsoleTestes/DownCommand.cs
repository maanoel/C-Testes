namespace ConsoleTestes
{
  public class DownCommand : IComando
  {
    public Submarino Submarino { get; private set; }
    public int Valor { get; private set; }

    public DownCommand(Submarino submarino, int valor)
    {
      Submarino = submarino;
      Valor = valor;
    }

    public void Executar()
    {
      Submarino.AumentarProfundidade(Valor);
    }
  }
}
