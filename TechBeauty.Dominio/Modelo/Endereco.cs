using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string Uf { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }

        public static Endereco CadastrarEndereco(int Id, string Logradouro, string Cidade, string Uf, string Numero, string Complemento)
        {
            Endereco endereco = new Endereco();
            endereco.Id = Id;
            endereco.Logradouro = Logradouro;
            endereco.Cidade = Cidade;
            endereco.Uf = Uf;
            endereco.Numero = Numero;
            endereco.Complemento = Complemento;
            return endereco;
        }

        internal void MudarEndereco(Endereco endereco)
        {
            this.Logradouro = endereco.Logradouro;
            this.Cidade = endereco.Cidade;
            this.Uf = endereco.Uf;
            this.Numero = endereco.Numero;
            this.Complemento = endereco.Complemento;
        }
    }
}