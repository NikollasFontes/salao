using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ColaboradorRepositorio
    {
        private List<Colaborador> TabelaColaborador { get; set; } = new List<Colaborador>();

        public void Incluir(Colaborador colaborador)
        {
            TabelaColaborador.Add(colaborador);
        }

        public void Alterar(int id, Colaborador colaborador)
        {
            TabelaColaborador.FirstOrDefault(x => x.Id == id).AlterarColaborador(colaborador);
        }

        public Colaborador PegarColaborador(int id)
        {
            return TabelaColaborador.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaColaborador.Remove(TabelaColaborador.FirstOrDefault(x => x.Id == id));
        }

        public List<Colaborador> Tabela()
        {
            return TabelaColaborador;
        }
    }
}