using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public int Legajo { get; set; }
        protected virtual void MostrarDatos()
        {

        }

        protected abstract void ParticiparEnClase();

        public static bool operator ==(Universitario uno, Universitario dos)
        {
           return (uno.Legajo == dos.Legajo || uno.Dni == dos.Dni) ? true : false;
        }

        public static bool operator !=(Universitario uno, Universitario dos)
        {
            return !(uno == dos);
        }
    }
}
