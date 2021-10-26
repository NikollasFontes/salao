using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ContatoRepositorio
    {
        private List<Contato> TabelaContato { get; set; } = new List<Contato>();

        public void Incluir(Contato contato)
        {
            TabelaContato.Add(contato);
        }

        public void Alterar(int id, Contato contato)
        {
            TabelaContato.FirstOrDefault(x => x.Id == id).AlterarContato(contato.Valor);
        }

        public Contato PegarContato(int id)
        {
            return TabelaContato.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaContato.Remove(TabelaContato.FirstOrDefault(x => x.Id == id));
        }

        public List<Contato> Tabela()
        {
            return TabelaContato;
        }
    }
}