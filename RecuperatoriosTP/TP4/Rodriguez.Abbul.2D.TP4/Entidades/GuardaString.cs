using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            StreamWriter guardar = new StreamWriter(archivo); //Leeremos el archivo

            try
            {
                guardar.WriteLine(texto);

                return true;

            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                guardar.Close();
            }
        }
    }
}
