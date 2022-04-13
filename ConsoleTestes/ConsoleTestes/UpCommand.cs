namespace ConsoleTestes
{
  public class UpCommand : IComando
  {
    public Submarino Submarino { get; private set; }
    public int Valor { get; private set; }

    public UpCommand(Submarino submarino, int valor)
    {
      Submarino = submarino;
      Valor = valor;
    }

    public void Executar()
    {
      Submarino.DiminuirProfundidade(Valor);
    }
  }
}
