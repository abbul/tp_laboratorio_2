using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            bool flag = false;
            XmlTextWriter archivoReceptor = new XmlTextWriter(archivo, Encoding.UTF8);  //indicamos q guardaremos y con cual codificacion
            XmlSerializer serializador = new XmlSerializer(typeof(T)); //objeto ha Serializar.

            try
            {
                serializador.Serialize(archivoReceptor, datos); // "datos" se serializarada dentro de "archivoReceptor".
                flag = true;
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
                archivoReceptor.Close();
            }

            return flag;
        }

        public bool Leer(string archivo, out T datos)
        {
            bool flag = false;

            XmlTextReader XmlReader = new XmlTextReader(archivo);  //Leeremos el archivo
            XmlSerializer objetoDeserializador = new XmlSerializer(typeof(T)); //objeto ha Deserializar.

            try
            {

                datos = (T)objetoDeserializador.Deserialize(XmlReader);//Deserializa el archivo contenido en XmlReader, lo guarda en datos

                flag = true;
                
            }
            catch (ArchivosException exception)
            {
                throw exception.InnerException;
            }

            finally
            {
                XmlReader.Close();
            }

            return flag;
        }
    }
}
