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
            catch (ArchivosException exception)
            {
                throw exception.InnerException;
            }

            catch (Exception exception)
            {
                throw exception.InnerException;
            }

            finally
            {
                guardar.Close();
            }
        }

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
            catch (ArchivosException exception)
            {
                throw exception.InnerException;
            }

            catch (Exception exception)
            {
                throw exception.InnerException;
            }

            finally
            {
                leerArchivo.Close();
            } 
        }
    }
}
