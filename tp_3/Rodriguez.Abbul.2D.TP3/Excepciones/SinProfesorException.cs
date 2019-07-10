using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Se lanza cuando se intenta agregar una clase y ninguna profesor la pueda dar.
    /// </summary>
    public class SinProfesorException : Exception
    {
        public SinProfesorException()
            : base("Error: No hay Profesor para esa clase")
        {
        }
    }
}
