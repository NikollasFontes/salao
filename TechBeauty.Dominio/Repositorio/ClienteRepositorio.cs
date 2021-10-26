using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ClienteRepositorio
    {
        private List<Cliente> TabelaCliente { get; set; } = new List<Cliente>();

        public void Incluir(Cliente cliente)
        {
            TabelaCliente.Add(cliente);
        }

        public void Alterar(int id, Cliente cliente)
        {
            TabelaCliente.FirstOrDefault(x => x.Id == id).AlterarCliente(cliente);
        }

        public Cliente PegarCliente(int id)
        {
            return TabelaCliente.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaCliente.Remove(TabelaCliente.FirstOrDefault(x => x.Id == id));
        }

        public List<Cliente> Tabela()
        {
            return TabelaCliente;
        }
    }
}