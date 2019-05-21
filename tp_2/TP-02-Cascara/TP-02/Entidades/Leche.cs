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
    private const int cantidadcalorias = 20;

    /// <summary>
    /// Los tipos de leches posibles
    /// </summary>
    public enum ETipo { Entera, Descremada }

    /// <summary>
    /// Pasa los parametros al constrcutor padre, excepto el "tipo". Sino se pasa el "tipo", por default es Entera.
    /// </summary>
    /// <param name="marca"></param>
    /// <param name="codigoDeBarras"></param>
    /// <param name="color"></param>
    /// <param name="tipo"></param>
    public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color)
        : base(marca, codigoDeBarras, color)
    {
        tipo = ETipo.Entera;
    }

    public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo)
        : base(marca, codigoDeBarras, color)
    {
      this.tipo = tipo;
    }

    /// <summary>
    /// Retorna las calorias del objeto. Es una constante
    /// </summary>
    public override short CantidadCalorias
    {
      get { return cantidadcalorias; }
    }

    /// <summary>
    /// Muestra toda la informacion del Objeto Actual
    /// </summary>
    public sealed override string Mostrar()
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
