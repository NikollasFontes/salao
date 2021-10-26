using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class CargoRepositorio
    {

        private List<Cargo> TabelaCargo { get; set; } = new List<Cargo>();

        public void incluir(Cargo cargo)
        {
            TabelaCargo.Add(cargo);
        }

        public void Atualizar(int id, Cargo cargo)
        {
            TabelaCargo.FirstOrDefault(x => x.Id == id).AlterarCargo(cargo.Nome, cargo.Descricao);
        }

        public Cargo PegarCargo(int id)
        {
            return TabelaCargo.FirstOrDefault(x => x.Id == id);
        }

        public void Remover(int id)
        {
            TabelaCargo.Remove(TabelaCargo.FirstOrDefault(x => x.Id == id));
        }

        public List<Cargo> Tabela()
        {
            return TabelaCargo;
        }
    }
}