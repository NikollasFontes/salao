using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa
    {
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string Nomesocial { get; private set; }
        public ContratoTrabalho ContratoTrabalho { get; private set; }


        public static Colaborador CriarColaborador(int Id, string Nome, string CPF, DateTime DataNascimento,
            List<Contato> Contatos, List<Servico> Servicos, Endereco Endereco, Genero Genero,
            string Nomesocial, ContratoTrabalho ContratoTrabalho)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = Id;
            colaborador.Nome = Nome;
            colaborador.Cpf = CPF;
            colaborador.DataNascimento = DataNascimento;
            colaborador.Contatos = Contatos;
            colaborador.Servicos = Servicos;
            colaborador.Endereco = Endereco;
            colaborador.Genero = Genero;
            colaborador.Nomesocial = Nomesocial;
            colaborador.ContratoTrabalho = ContratoTrabalho;
            return colaborador;
        }

        internal void AlterarColaborador(Colaborador colaborador)
        {
            Nome = colaborador.Nome;
            Cpf = colaborador.Cpf;
            DataNascimento = colaborador.DataNascimento;
            Contatos = colaborador.Contatos;
            Servicos = colaborador.Servicos;
            Endereco = colaborador.Endereco;
            Genero = colaborador.Genero;
            Nomesocial = colaborador.Nomesocial;
            ContratoTrabalho = colaborador.ContratoTrabalho;
        }
    }
}