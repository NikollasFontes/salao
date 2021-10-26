using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public Colaborador Colaborador { get; private set; }

        public static Escala GerarEscala(int Id, DateTime DataHoraEntrada, DateTime DataHoraSaida, Colaborador Colaborador)
        {
            Escala escala = new Escala();
            escala.Id = Id;
            escala.DataHoraEntrada = DataHoraEntrada;
            escala.DataHoraSaida = DataHoraSaida;
            escala.Colaborador = Colaborador;
            return escala;
        }

        internal void AlterarEscala(Escala escala)
        {
           DataHoraEntrada = escala.DataHoraEntrada;
           DataHoraSaida = escala.DataHoraSaida;
           Colaborador = escala.Colaborador;
        }
    }
}