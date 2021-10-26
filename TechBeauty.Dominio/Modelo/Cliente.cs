using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa
    {
        public static Cliente CriarCliente(int Id, string Nome, string Cpf, DateTime DataNascimento, List<Contato> Contatos)
        {
            Cliente cliente = new  Cliente();
            cliente.Id = Id;
            cliente.Nome = Nome;
            cliente.Cpf = Cpf;
            cliente.DataNascimento = DataNascimento;
            cliente.Contatos = Contatos;
            return cliente;
        }

        void AlterarCliente(Cliente cliente)
        {
            Nome = cliente.Nome;
            Cpf = cliente.Cpf;
            DataNascimento = cliente.DataNascimento;
            Contatos = cliente.Contatos;
        }
    }
}
