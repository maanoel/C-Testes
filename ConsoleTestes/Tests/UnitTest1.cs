using ConsoleTestes;
using System;
using System.IO;
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

    [Fact]
    public void DeveLerOsComandoDeUmArquivoExterno()
    {
      ControleSubmarinoBuilder builder = new ControleSubmarinoBuilder();
      Submarino submarino = new Submarino();

      var linhas = File.ReadAllLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Submarino.txt");

      foreach(var linha in linhas)
      {
        string nomeComando = linha.Substring(0, linha.Length - 1);
        int argumentoComando = int.Parse(linha.Substring(linha.Length - 1, 1));
        IComando comando = new CommandoCreator(submarino, nomeComando, argumentoComando).Criar();

        builder.AdicionarComando(comando);
      }

      builder.ExecutarComandos();

      Assert.NotNull(builder);
    }

    [Fact]
    public void DeveInserirSeisComandosERetornar900()
    {
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

      Assert.Equal(900, submarino.Multiplicar());
    }


    [Fact]
    public void DeveLerOsComandoDeUmArquivoExternoCalculandoMira()
    {
      ControleSubmarinoBuilder builder = new ControleSubmarinoBuilder();
      Submarino submarino = new Submarino();

      var linhas = File.ReadAllLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Submarino2.txt");

      foreach(var linha in linhas)
      {
        string nomeComando = linha.Substring(0, linha.Length - 1);
        int argumentoComando = int.Parse(linha.Substring(linha.Length - 1, 1));
        IComando comando = new CommandoCreator(submarino, nomeComando, argumentoComando).Criar();

        builder.AdicionarComando(comando);
      }

      builder.ExecutarComandos();

      Assert.NotNull(builder);
    }

    [Fact]
    public void DeveCalcularOGamaEEpsilonRetornando198() {

      string[] linhas = File.ReadAllLines($@"C:\Users\manoel.vitor\Desktop\teste\C-Testes\Submarino3.txt");
      CalculadoraSubmarino calculadoraGama = new CalcularDoraGama(linhas);
      CalculadoraSubmarino calculadoraEpsilon = new CalculadoraEpsilon(linhas);

      int consumoDeEnergia = calculadoraGama.Calcular() * calculadoraEpsilon.Calcular();
      Assert.Equal(3320834, consumoDeEnergia);
    }
  }
}
