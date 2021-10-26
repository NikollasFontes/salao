using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho
    {
        public int Id { get; private set; }
        public RegimeContratual RegimeContratual { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; set; }
        public List<Cargo> Cargos { get; private set; }
        public string CnpjCtps { get; private set; }

        public static ContratoTrabalho Contratar(int Id, RegimeContratual regimeContratual, DateTime DataHoraEntrada,
            List<Cargo> Cargos, string CnpjCtps)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Id = Id;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = DataHoraEntrada;
            contratoTrabalho.CnpjCtps = CnpjCtps;
            contratoTrabalho.Cargos = Cargos;
            return contratoTrabalho;
        }

        public void EncerrarContrato(DateTime DataDesligamento)
        {
            this.DataDesligamento = DataDesligamento;
        }

        public void Modificarcontrato(ContratoTrabalho contratoTrabalho)
        {
            RegimeContratual = contratoTrabalho.RegimeContratual;
            DataEntrada = contratoTrabalho.DataEntrada;
            Cargos = contratoTrabalho.Cargos;
            CnpjCtps = contratoTrabalho.CnpjCtps;
        }

        public void ExcluirCargo(int id)
        {
            Cargos.Remove(Cargos.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}