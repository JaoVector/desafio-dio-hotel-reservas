using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservas.Classes
{
    public class Reserva
    {
        public List<Pessoa>? Pessoas { get; set; }
        public Suite? Suite { get; set; }
        public int? QtdDiasReserva { get; set; }

        public Reserva(List<Pessoa> pessoas, Suite suite, int qtdDiasReserva)
        {
            Pessoas = pessoas;
            Suite = suite;
            QtdDiasReserva = qtdDiasReserva;
        }
    }
}
