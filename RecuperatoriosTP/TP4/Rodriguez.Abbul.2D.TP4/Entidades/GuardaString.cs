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

        public static bool Guardar(this string datos, string archivo)
        {
            bool flag = false;
            StreamWriter guardar = new StreamWriter(archivo); //Leeremos el archivo

            try
            {
                guardar.WriteLine(datos);
                flag = true;

                return flag;

            }
            catch (Exception exception)
            {
                throw exception;
            }

            finally
            {
                guardar.Close();
            }
        }
    }


}
