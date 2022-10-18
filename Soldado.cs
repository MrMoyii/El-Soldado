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
            _arma = arma;
        }
        public void DejarArma()
        {
            _arma = null;
        }
        public void Disparar()
        {
            Console.WriteLine(_arma.Disparar());
        }
        public void VerArma()
        {
            Console.WriteLine(_arma.GetType());
        }
    }
}
