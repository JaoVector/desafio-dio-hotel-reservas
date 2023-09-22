using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Reservas.Classes;

namespace Hotel_Reservas.Classes
{
    public interface ICadastro<T>
    {
        void InsereDados(T entry);
        List<T> GetList();
    }
}