using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ServicoRepositorio
    {
        private List<Servico> TabelaServico { get; set; } = new List<Servico>();

        public void Incluir(Servico servico)
        {
            TabelaServico.Add(servico);
        }

        public void Alterar(int id, Servico servico)
        {
            TabelaServico.FirstOrDefault(x => x.Id == id).ModificarServico(servico);
        }

        public Servico PegarServico(int id)
        {
            return TabelaServico.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaServico.Remove(TabelaServico.FirstOrDefault(x => x.Id == id));
        }

        public List<Servico> Tabela()
        {
            return TabelaServico;
        }
    }
}