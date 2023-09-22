using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservas.Classes
{
    public class Suite
    {
        public int? NumQuarto { get; set; }
        public string? Tamanho { get; set; }
        public string? Tipo { get; set; }
        public double? Preco { get; set; }
        public bool? TemBanheira { get; set; }


        public Suite(int numQuarto, string tamanho, string tipo, double preco, bool temBanheira)
        {
            NumQuarto = numQuarto;
            Tamanho = tamanho;
            Tipo = tipo;
            Preco = preco;
            TemBanheira = temBanheira;
        }
    }
}