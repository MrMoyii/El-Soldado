using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Soldado
    {
        private Arma _arma;
        public void RecogerArma(Arma arma)
        {
            if (_arma != null)
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            } 
            else _arma = arma;

        }
        public void DejarArma()
        {
            _arma = null;
        }
        public void Disparar()
        {
            if (_arma == null)
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            }
            else Console.WriteLine(_arma.Disparar());
        }
        public void VerArma()
        {
            if (_arma == null)
            {
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos...");
            }
            else Console.WriteLine(_arma.Nombre);

        }
    }
}
