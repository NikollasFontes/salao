using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Servico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public Decimal Valor { get; private set; }
        public string Descricao { get; private set; }
        public int DuracaoEmMin { get; private set; }

        public static Servico RegistrarServico(int Id, string Nome, decimal Valor, string Descricao, int DuracaoEmMin)
        {
            Servico servico = new Servico();
            servico.Id = Id;
            servico.Nome = Nome;
            servico.Valor = Valor;
            servico.Descricao = Descricao;
            servico.DuracaoEmMin = DuracaoEmMin;
            return servico;
        }

        internal void ModificarServico(Servico servico)
        {
            Nome = servico.Nome;
            Valor = servico.Valor;
            Descricao = servico.Descricao;
            DuracaoEmMin = servico.DuracaoEmMin;
        }
    }
}