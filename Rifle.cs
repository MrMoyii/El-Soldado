using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public Rifle()
        {
            nombre = "Rifle";
        }
        public override string Disparar()
        {
            return "Púm púm púm...";
        }

    }
}
