using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Se lanza cuando el DNI no cumple con la cantidad de caracteres o cuando esta fuera del rango logico.
    /// </summary>
    public class DniInvalidoException : Exception
    {

        public DniInvalidoException(Exception e)
           : base(String.Format("Error:  {0}", e))
        {

        }

        public DniInvalidoException(string mensaje)
            : base(String.Format("Error: {0}", mensaje))
        {

        }

        public DniInvalidoException(string mensaje, Exception e)
           : base(String.Format("Error: {0}", mensaje))
        {

        }
    }
}
