using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class TipoContatoRepositorio
    {
        private List<TipoContato> TabelaTipoContato { get; set; } = new List<TipoContato>();

        public void Incluir(TipoContato tipoContato)
        {
            TabelaTipoContato.Add(tipoContato);
        }

        public void Atualizar(int id, TipoContato tipoContato)
        {
            TabelaTipoContato.FirstOrDefault(x => x.Id == id).AtualizarTipoContato(tipoContato.Valor);
        }

        public TipoContato PegarTipoContato(int id)
        {
            return TabelaTipoContato.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaTipoContato.Remove(TabelaTipoContato.FirstOrDefault(x => x.Id == id));
        }

        public List<TipoContato> Tabela()
        {
            return TabelaTipoContato;
        }
    }
}