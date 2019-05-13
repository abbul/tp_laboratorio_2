using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        private ETipo tipo;

        public enum ETipo { Entera, Descremada }

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>

        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo= ETipo.Entera)
            : base(marca, codigoDeBarras, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS: " + CantidadCalorias + " " + "TIPO: " + tipo);
            sb.AppendLine(" ");
            sb.AppendLine("---------------------");

            return Convert.ToString(sb);
        }
    }
}
