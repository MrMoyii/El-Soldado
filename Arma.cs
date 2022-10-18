using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSoldado
{
    abstract class Arma
    {
        protected string nombre;

        public abstract string Disparar();
    }
}
