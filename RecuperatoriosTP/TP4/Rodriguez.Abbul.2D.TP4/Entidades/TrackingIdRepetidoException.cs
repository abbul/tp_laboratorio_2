using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class TrackingIdRepetidoException : Exception
    {
        public TrackingIdRepetidoException(string mensaje)
                : base(String.Format("Error: {0}", mensaje))
        {

        }

        public TrackingIdRepetidoException(string mensaje,Exception inner)
                : base(String.Format("Error: {0} -- {1}", mensaje,inner.Message))
        {

        }
    }
}
