using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class TipoContato
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }

        public static TipoContato CriarTipoContato(int Id, string Valor)
        {
            TipoContato contato = new TipoContato();
            contato.Id = Id;
            contato.Valor = Valor;
            return contato;
        }

        public void AtualizarTipoContato(string Valor)
        {
           Valor = Valor;
        }
    }
}