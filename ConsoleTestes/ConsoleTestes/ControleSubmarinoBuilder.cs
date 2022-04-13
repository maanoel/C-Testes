using System.Collections.Generic;

namespace ConsoleTestes
{
  public class ControleSubmarinoBuilder
  {
    private readonly IList<IComando> comandos = new List<IComando>();

    public ControleSubmarinoBuilder AdicionarComando(IComando comando) {
      comandos.Add(comando);
      return this;
    }

    public void ExecutarComandos() {
      foreach(var comando in comandos)
        comando.Executar();
    }
  }
}
