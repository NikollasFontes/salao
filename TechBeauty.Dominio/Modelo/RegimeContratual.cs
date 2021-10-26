using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }

        public static RegimeContratual CriarRegimeContratual(int Id, string Valor)
        {
            RegimeContratual regimeContratual = new RegimeContratual();
            regimeContratual.Id = Id;
            regimeContratual.Valor = Valor;
            return regimeContratual;
        }

        internal void AlterarRegimeContratual(RegimeContratual regimeContratual)
        {
            Valor = regimeContratual.Valor;
        }
    }
}