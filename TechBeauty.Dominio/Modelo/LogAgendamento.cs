using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento
    {
        public DateTime DataCriacao { get; set; }
        public StatusAgendamento Status { get; set; }
        public int IdAgendamento { get; set; }

        public static LogAgendamento CriarLogAgendamento(DateTime dataCriacao, StatusAgendamento status, int idAgendamento)
        {
            LogAgendamento logAgendamento = new LogAgendamento();
            logAgendamento.DataCriacao = dataCriacao;
            logAgendamento.Status = status;
            logAgendamento.IdAgendamento = idAgendamento;
            return logAgendamento;
        }


    }
}