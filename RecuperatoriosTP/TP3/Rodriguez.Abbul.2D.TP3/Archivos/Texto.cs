using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public static class Texto
    {
        /// <summary>
        /// Guardar la informacion dada en un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Guardar(string archivo, string datos)
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
                throw new ArchivosException(exception);
            }

            finally
            {
                guardar.Close();
            }
        }

        /// <summary>
        /// Leer y carga la informacion en el variable dada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Leer(string archivo, out string datos)
        {
            bool flag = false;
            StreamReader leerArchivo = new StreamReader(archivo, Encoding.UTF8);  //Leeremos el archivo

            try
            {
                do
                {
                    datos = leerArchivo.ReadLine();
                    flag = true;

                } while (leerArchivo.EndOfStream == true);

                return flag;

            }
            catch (Exception exception)
            {
                throw new ArchivosException(exception);
            }

            finally
            {
                leerArchivo.Close();
            } 
        }
    }
}
