using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservas.Classes
{
    public class CadPessoa : ICadastro<Pessoa>
    {
        private List<Pessoa> _listPessoas;

        public CadPessoa()
        {
            _listPessoas = new List<Pessoa>();
        }

        public void InsereDados(Pessoa pessoa) => _listPessoas.Add(pessoa);
        public List<Pessoa> GetList() => _listPessoas;
        public int QuantidadePessoas() => _listPessoas.Count;
    }
}