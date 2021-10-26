using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class RegimeContratualRepositorio
    {
        private List<RegimeContratual> TabelaRegimeContratual { get; set; } = new List<RegimeContratual>();

        public void Incluir(RegimeContratual regimeContratual)
        {
            TabelaRegimeContratual.Add(regimeContratual);
        }

        public void Alterar(int id, RegimeContratual regimeContratual)
        {
            TabelaRegimeContratual.FirstOrDefault(x => x.Id == id).AlterarRegimeContratual(regimeContratual);
        }

        public RegimeContratual PegarRegimeContratual(int id)
        {
            return TabelaRegimeContratual.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaRegimeContratual.Remove(TabelaRegimeContratual.FirstOrDefault(x => x.Id == id));
        }

        public List<RegimeContratual> Tabela()
        {
            return TabelaRegimeContratual;
        }
    }
}