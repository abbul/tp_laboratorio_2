using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Se lanza cuando el numero de DNI esta fuera del rango por su Nacionalidad
    /// </summary>
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
        {

        }
        public NacionalidadInvalidaException(string mensaje)
            : base(String.Format("Error: {0}", mensaje))
        {

        }
    }
}
