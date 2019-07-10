using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Se lanza cuando un alumno ya esta agregado a una Universidad
    /// </summary>
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException()
            : base("Error: Alumno Repetido")
        {
        }
    }
}
