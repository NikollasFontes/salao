using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class EscalaRepositorio
    {
        private List<Escala> TabelaEscala { get; set; } = new List<Escala>();

        public void Incluir(Escala escala)
        {
            TabelaEscala.Add(escala);
        }

        public void Aletar(int id, Escala escala)
        {
            TabelaEscala.FirstOrDefault(x => x.Id == id).AlterarEscala(escala);
        }

        public Escala PegarEscala(int id)
        {
            return TabelaEscala.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaEscala.Remove(TabelaEscala.FirstOrDefault(x => x.Id == id));
        }

        public List<Escala> Tabela()
        {
            return TabelaEscala;
        }
    }
}