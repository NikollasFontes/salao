using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {
        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendida { get; private set; }
        public DateTime DataHora { get; private set; }
        public OrdemServico OrdemServico { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraExecucao { get; private set; }
        public StatusAgendamento StatusAgendamento { get; private set; }
        public decimal Comissao { get; private set; }

        public static Agendamento CriarAgendamento(int Id, Servico Servico, Colaborador Colaborador,
            string PessoaAtendida, DateTime DataHora, OrdemServico OrdemServico,
            DateTime DataHoraCriacao)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = Id;
            agendamento.Servico = Servico;
            agendamento.Colaborador = Colaborador;
            agendamento.PessoaAtendida = PessoaAtendida;
            agendamento.DataHora = DataHora;
            agendamento.OrdemServico = OrdemServico;
            agendamento.DataHoraCriacao = DataHoraCriacao;
            agendamento.StatusAgendamento = StatusAgendamento.Agendado;
            agendamento.Comissao = RegistrarComissao(Servico);
            return agendamento;
        }

        public void ExecucaoServico(DateTime DataHoraExecucao)
        {
            DataHoraExecucao = DataHoraExecucao;
        }

        public void AlterarStatusAgendamento(StatusAgendamento status)
        {
            StatusAgendamento = status;
        }

        public void ModificarAgendamento(Servico servico, Colaborador colaborador,
            string pessoaAtendida, DateTime dataHora, OrdemServico ordemServico, StatusAgendamento statusAgendamento)
        {
            Servico = servico;
            Colaborador = colaborador;
            PessoaAtendida = pessoaAtendida;
            DataHora = dataHora;
            OrdemServico = ordemServico;
            StatusAgendamento = statusAgendamento;
        }

        private static decimal RegistrarComissao(Servico servico)
        {
            return servico.Valor / 60;
        }
    }
}