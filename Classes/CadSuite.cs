using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservas.Classes
{
    public class CadSuite : ICadastro<Suite>
    {
        private List<Suite> _listSuites;

        public CadSuite()
        {
            _listSuites = new List<Suite>();
        }

        public void InsereDados(Suite suite) => _listSuites.Add(suite);
        public List<Suite> GetList() => _listSuites;
        public Suite? GetSuitePorNumQuarto(int numQuarto) => _listSuites.Find(x => x.NumQuarto == numQuarto);
    }
}