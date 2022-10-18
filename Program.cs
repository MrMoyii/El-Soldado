using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado soldado1 = new Soldado();

            byte opcion;
            do
            {
                opcion = MostrarMenuPrincipal();
                switch (opcion)
                {
                    //Recoger un arma
                    case 1:

                        byte opcionArma = MostrarMenuUno.MostrarMenu();
                        MostrarMenuUno.agregarArmaSoldado(opcionArma, ref soldado1);
                        Console.ReadKey();
                        break;

                    //Dejar arma
                    case 2:
                        soldado1.DejarArma();
                        Console.ReadKey();
                        break;

                    //Disparar
                    case 3:
                        soldado1.Disparar();
                        Console.ReadKey();
                        break;

                    //Ver arma en uso
                    case 4:
                        soldado1.VerArma();
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 5);
        }
        static byte MostrarMenuPrincipal()
        {
            //muestra el menu principal y se va a ejecutar hasta 
            //que se ingrese un número valio entre 1 y 5.
            byte opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==-\n");
                Console.WriteLine("¿Qué desea hacer?\n(presione el número correspondiente a la opción del menú)\n");
                Console.WriteLine("1- Recoger arma.");
                Console.WriteLine("2- Dejar arma.");
                Console.WriteLine("3- Disparar.");
                Console.WriteLine("4- Ver arma en uso.");
                Console.WriteLine("5- Salir.");
            } while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 5);
            return opcion;
        }
        //static byte MostrarMenuUno()
        //{
        //    byte opcion = 0;
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
        //        Console.WriteLine("1- Revolver");
        //        Console.WriteLine("2- Rifle");
        //        Console.WriteLine("3- Escopeta");
        //        Console.WriteLine("4- Volver atrás");
        //    } while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 4);
        //    return opcion;
        //}
    }
}
