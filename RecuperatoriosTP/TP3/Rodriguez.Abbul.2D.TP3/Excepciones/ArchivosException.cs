using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Se lanzar por cualquier Exception al momento de cargar o leer un archivo
    /// </summary>
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException)
        {
            String.Format("Error: " + innerException.ToString() );
        }
    }
}
