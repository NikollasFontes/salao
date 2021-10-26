using TechBeauty.Dominio.Repositorio;
using System;
   namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {
         

            GeneroRepositorio repoGenero = new GeneroRepositorio();
            TipoContatoRepositorio repoTipoContato = new TipoContatoRepositorio();
            ContatoRepositorio repoContato = new ContatoRepositorio(repoTipoContato.TabelaTipoContato);
            CargoRepositorio repoCargo = new CargoRepositorio();

            repoCargo.Alterar(1, "Thamy", "Gameiro");
            repoCargo.Excluir(1);
            var x = repoTipoContato.PegarCargo(1);

            foreach (var item in repoContato.TabelaContato)

            {
                Console.WriteLine("os Nome são" + item.Valor);
            }
        }
    }
}
