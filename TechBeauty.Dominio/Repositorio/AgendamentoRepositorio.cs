using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class AgendamentoRepositorio
    {
        private List<Agendamento> TabelaAgendamento { get; set; } = new List<Agendamento>();

        public void Incluir(Agendamento agendamento)
        {
            TabelaAgendamento.Add(agendamento);
        }

        public List<Agendamento> Agendamentos(int id)
        {
            //List<Agendamento> ag = TabelaAgendamento.FirstOrDefault();
            return null;
        }

        public List<Agendamento> Tabela()
        {
            return TabelaAgendamento;
        }
    }
}