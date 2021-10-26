using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ContratoTrabalhoRepositorio
    {
        private List<ContratoTrabalho> TabelaContratoTrabalho { get; set; } = new List<ContratoTrabalho>();

        public void Incluir(ContratoTrabalho contratoTrabalho)
        {
            TabelaContratoTrabalho.Add(contratoTrabalho);
        }

        public void Alterar(int id, ContratoTrabalho contratoTrabalho)
        {
            TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id).Modificarcontrato(contratoTrabalho);
        }

        public void EncerramentoContrato(int id, DateTime dataDesligamento)
        {
            TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id).EncerrarContrato(dataDesligamento);
        }

        public ContratoTrabalho PegarContratoTrabalho(int id)
        {
            return TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaContratoTrabalho.Remove(TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id));
        }

        public List<ContratoTrabalho> Tabela()
        {
            return TabelaContratoTrabalho;
        }
    }
}