using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public StatusOS StatusOS { get; private set; }

        public static OrdemServico AbrirOrdemServico(int Id, int DuracaTotal, Cliente Cliente, StatusOS StatusOS)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.Cliente = Cliente;
            ordemServico.DuracaTotal = DuracaTotal;
            ordemServico.Id = Id;
            ordemServico.PrecoTotal = 0.0M;
            ordemServico.StatusOS = StatusOS;
            return ordemServico;
        }

        internal void AlterarOrdemServico(OrdemServico ordemServico)
        {
            PrecoTotal = ordemServico.PrecoTotal;
            StatusOS = ordemServico.StatusOS;
            DuracaTotal = ordemServico.DuracaTotal;
            Cliente = ordemServico.Cliente;
        }

        public void AlterarPrecoTotal(decimal PrecoTotal)
        {
            PrecoTotal += PrecoTotal;
        }

        public void ModificarStatusOrdemServico(StatusOS statusOS)
        {
            StatusOS = statusOS;
        }
    }
}