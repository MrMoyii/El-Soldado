using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    static class MostrarMenuUno
    {
        static public byte MostrarMenu()
        {
            byte opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
                Console.WriteLine("1- Revolver");
                Console.WriteLine("2- Rifle");
                Console.WriteLine("3- Escopeta");
                Console.WriteLine("4- Volver atrás");
            } while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4);
            return opcion;
        }
        static public void agregarArmaSoldado(byte arma, ref Soldado  soldado)
        {
            switch (arma)
            {
                //recoge un Revolver
                case 1:
                    soldado.RecogerArma(new Revolver());
                    //Console.WriteLine("Revolver");
                    Console.ReadKey();
                    break;
                //recoge un Rifle
                case 2:
                    soldado.RecogerArma(new Rifle());
                    Console.WriteLine("Rifle");
                    Console.ReadKey();
                    break;
                //recoge una Escopeta
                case 3:
                    soldado.RecogerArma(new Escopeta());
                    Console.WriteLine("Escopeta");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
