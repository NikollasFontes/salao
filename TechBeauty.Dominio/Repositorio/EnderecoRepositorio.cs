using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class EnderecoRepositorio
    {
        private List<Endereco> TabelaEndereco { get; set; } = new List<Endereco>();

        public void Incluir(Endereco endereco)
        {
            TabelaEndereco.Add(endereco);
        }

        public void Alterar(int id, Endereco endereco)
        {
            TabelaEndereco.FirstOrDefault(x => x.Id == id).AlterarEndereco(endereco);
        }

        public Endereco PegarEndereco(int id)
        {
            return TabelaEndereco.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaEndereco.Remove(TabelaEndereco.FirstOrDefault(x => x.Id == id));
        }

        public List<Endereco> Tabela()
        {
            return TabelaEndereco;
        }
    }
}