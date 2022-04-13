namespace ConsoleTestes
{
  public class CommandoCreator
  {
    public Submarino Submarino { get; }
    public string NomeComando { get; }
    public int Argumento { get; }

    public CommandoCreator(Submarino submarino, string nomeComando, int argumento)
    {
      Submarino = submarino;
      NomeComando = nomeComando;
      Argumento = argumento;
    }

    public IComando Criar() {

      switch(NomeComando.Trim())
      {
        case "forward":
          return new FowardCommand(Submarino, Argumento);
        case "up":
          return new UpCommand(Submarino, Argumento);
        case "down":
          return new DownCommand(Submarino, Argumento);
      }

      return null;
    }
  }
}
