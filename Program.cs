using Hotel_Reservas.Classes;

namespace Hotel_Reservas
{
   public class Program
   {
      static void Main()
      {

        var pessoas = new CadPessoa();
        var suites = new CadSuite();

        pessoas.InsereDados(new Pessoa("Jose", "Marchal"));
        pessoas.InsereDados(new Pessoa("Lucas", "Rodrigues"));

        suites.InsereDados(new Suite(1, "40m", "Luxo", 100.00, true));
        suites.InsereDados(new Suite(2, "60m", "Luxo Plus", 250.00, false));

        var listaPessoas = pessoas.GetList();
        var suite = suites.GetSuitePorNumQuarto(2);
        
        var reserva = new Reserva(listaPessoas, suite, 12);
        CalculoDescontos.CalculaDesconto(reserva.Suite, reserva.QtdDiasReserva);

        var qtdPessoas = pessoas.QuantidadePessoas();
        Console.WriteLine($"Quantidade de Pessoas: {qtdPessoas}");

      }
   }
}

