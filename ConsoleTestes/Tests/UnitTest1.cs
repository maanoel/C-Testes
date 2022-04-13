using ConsoleTestes;
using System;
using Xunit;

namespace Tests
{
  public class UnitTest1
  {
    [Fact]
    public void DeveMultiPlicarHorizontalProfundidadeERetornar150() {

      ControleSubmarinoBuilder builder = new ControleSubmarinoBuilder();
      Submarino submarino = new Submarino();

      builder.
      AdicionarComando(new FowardCommand(submarino, 5)).
      AdicionarComando(new DownCommand(submarino, 5)).
      AdicionarComando(new FowardCommand(submarino, 8)).
      AdicionarComando(new UpCommand(submarino, 3)).
      AdicionarComando(new DownCommand(submarino, 8)).
      AdicionarComando(new FowardCommand(submarino, 2));

      builder.ExecutarComandos();

      int multiplicador = submarino.Multiplicar();

      Assert.Equal(150, multiplicador);
    }
  }
}
