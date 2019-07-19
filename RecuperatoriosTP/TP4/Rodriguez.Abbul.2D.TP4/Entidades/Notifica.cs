using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Notifica
    {
        private static string path;
        public static void Send(string cadena, ETipoExcepcion tipo = ETipoExcepcion.generico)
        {
            StringBuilder sb = new StringBuilder();
            string info;
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\reporte.txt";

            sb.AppendLine("TIPO DE ERROR:" + Convert.ToString(tipo) );
            sb.AppendLine("DESCRIPCION:" + cadena);
            sb.AppendLine("___________________");

            info = Convert.ToString(sb);

            info.Guardar(path);
        }

        
    }

    public enum ETipoExcepcion
    {
        sql,
        clase,
        interfaz,
        generico
    }
}
