using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Contato
    {
        public int Id { get; private set; }
        public TipoContato Tipo { get; private set; }
        public string Valor { get; private set; }

        public static Contato CriarContato(int Id, string Valor, TipoContato TipoContato)
        {
            Contato contato = new Contato();
            contato.Id = Id;
            contato.Valor = Valor;
            contato.Tipo = TipoContato;
            return contato;
        }

        public void MudarContato(string contato)
        {
            Valor = contato;
        }

        public void AlterarTipoContato(TipoContato tipoContato)
        {
            Tipo = tipoContato;
        }
    }
}