using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class OrdemServicoRepositorio
    {
        private List<OrdemServico> TabelaOrdemServico { get; set; } = new List<OrdemServico>();

        public void Incluir(OrdemServico ordemServico)
        {
            TabelaOrdemServico.Add(ordemServico);
        }

        public void Alterar(int id, OrdemServico ordemServico)
        {
            TabelaOrdemServico.FirstOrDefault(x => x.Id == id).AlterarOrdemServico(ordemServico);
        }

        public OrdemServico PegarOrdemServico(int id)
        {
            return TabelaOrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaOrdemServico.Remove(TabelaOrdemServico.FirstOrDefault(x => x.Id == id));
        }

        public List<OrdemServico> Tabela()
        {
            return TabelaOrdemServico;
        }

        public void AlterarPrecototal(int id, decimal valor)
        {
            TabelaOrdemServico.FirstOrDefault(x => x.Id == id).AlterarPrecoTotal(valor);
        }
    }
}