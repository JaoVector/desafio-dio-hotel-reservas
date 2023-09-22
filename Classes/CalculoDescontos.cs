using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservas.Classes
{
    public static class CalculoDescontos
    {
        public static void CalculaDesconto(Suite suite, int? qtdDiasReserva)
        {
            if(qtdDiasReserva > 10)
            {
                var valorComDesconto = suite.Preco - (suite.Preco * 0.1);
                Console.WriteLine($"Total a pagar: {valorComDesconto} com desconto de 10%");
            } else 
            {
                Console.WriteLine($"Total a pagar: {suite.Preco} sem desconto");
            }
        }
    }
}