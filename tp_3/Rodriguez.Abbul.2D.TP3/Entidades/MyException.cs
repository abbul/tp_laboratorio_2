using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
        {

        }

        public NacionalidadInvalidaException(string nacionalidad)
            : base(String.Format("Naciondalidad invalida: {0}", nacionalidad))
        {

        }
    }

    class DniInvalidoException : Exception
    {
        public DniInvalidoException()
        {

        }

        public DniInvalidoException(string nacionalidad)
            : base(String.Format("Naciondalidad invalida: {0}", nacionalidad))
        {

        }
    }

    class StringInvalidoException : Exception
    {
        public StringInvalidoException()
        {

        }

        public StringInvalidoException(string nacionalidad)
            : base(String.Format("Naciondalidad invalida: {0}", nacionalidad))
        {

        }
    }
}
