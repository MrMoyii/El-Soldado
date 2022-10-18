using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    class Revolver : Arma
    {
        public Revolver()
        {
            nombre = "Revolver";
        }
        public override string Disparar()
        {
            return "Púm...";
        }
    }
}
