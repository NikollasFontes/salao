using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class GeneroRepositorio
    {
        private List<Genero> TabelaGenero { get; set; } = new List<Genero>();

        public void Incluir(Genero genero)
        {
            TabelaGenero.Add(genero);
        }

        public void Alterar(int id, Genero genero)
        {
            TabelaGenero.FirstOrDefault(x => x.Id == id).AlterarGenero(genero.Valor);
        }

        public Genero PegarGenero(int id)
        {
            return TabelaGenero.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaGenero.Remove(TabelaGenero.FirstOrDefault(x => x.Id == id));
        }

        public List<Genero> Tabela()
        {
            return TabelaGenero;
        }
    }
}