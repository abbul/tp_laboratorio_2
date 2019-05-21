using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks : Producto
    {
        private const int cantidadcalorias = 104;

        /// <summary>
        /// Pasa los parametros al constructor padre.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDeBarras"></param>
        /// <param name="color"></param>
        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color) : base(marca,codigoDeBarras, color)
        {
        }

        /// <summary>
        /// Retorna las calorias del objeto. Es una constante
        /// </summary>
        public override short CantidadCalorias
        {
          get { return cantidadcalorias;  }
        }

    /// <summary>
    /// Muestra toda la informacion del Objeto Actual
    /// </summary>
    public override string Mostrar()
       {
            
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("SNACKS");
                sb.AppendLine(base.Mostrar());
                sb.AppendLine("CALORIAS: " + CantidadCalorias);
                sb.AppendLine(" ");
                sb.AppendLine("---------------------");

                return Convert.ToString(sb);
            
        }
    }
}
