using System;
using FundamentosCSHARP.Models;

namespace FundamentoCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {

            ChelasBD chelasBD = new ChelasBD();

            // Inserción de las nuevas chelas

            /* Cerveza chelita = new Cerveza(22, "cristal");
             chelita.Marca = "cristall";
             chelita.Alcohol = 6;

             chelasBD.Add(chelita);
            */

            /* Cerveza chelita = new Cerveza(12, "Cristal");
            chelita.Marca = "Cristalito";
            chelita.Alcohol = 2;

            chelasBD.Edit(chelita,4);
            */

            chelasBD.Delete(4);

            // Obtener todas las chelas 
            var chelas = chelasBD.Get();

            foreach(var item in chelas)
            {
                Console.WriteLine(item.Nombre);
            }
        }
    }
}
