using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
      private EMarca marca;
      private string codigoDeBarras;
      private ConsoleColor colorPrimarioEmpaque;

      public Producto(EMarca marca, string codigoDeBarras, ConsoleColor colorPrimarioEmpaque)
      {
          this.marca = marca;
          this.codigoDeBarras = codigoDeBarras;
          this.colorPrimarioEmpaque = colorPrimarioEmpaque;
      }

      public enum EMarca
      {
          Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
      }

      /// <summary>
      /// Retornará la cantidad de calorias del producto. Metodo Abstract
      /// </summary>
      public abstract short CantidadCalorias { get; }

      /// <summary>
      /// Publica todos los datos del Producto. Metodo Virtual
      /// </summary>
      /// <returns></returns>
      public virtual string Mostrar()
      {
        return (string)this;
      }

      /// <summary>
      /// Al castear un Producto a string, convertirar toda su informacion a string.
      /// </summary>
      /// <param name="p"></param>
      public static explicit operator string(Producto p)
      {
          StringBuilder sb = new StringBuilder();

          sb.AppendLine("CODIGO DE BARRAS: " + p.codigoDeBarras);
          sb.AppendLine("MARCA           : " + p.marca.ToString());
          sb.AppendLine("COLOR EMPAQUE   : " + p.colorPrimarioEmpaque.ToString());
          sb.AppendLine("---------------------");

          return Convert.ToString(sb);
      }

      /// <summary>
      /// Compara dos productos. Son iguales si comparten el mismo código de barras
      /// </summary>
      /// <param name="v1"></param>
      /// <param name="v2"></param>
      /// <returns></returns>
      public static bool operator ==(Producto v1, Producto v2)
      {
          return (v1.codigoDeBarras == v2.codigoDeBarras) ? true : false;
      }

      /// <summary>
      /// Compara dos productos. Son distintos sino comparten el mismo código de barras
      /// </summary>
      /// <param name="v1"></param>
      /// <param name="v2"></param>
      /// <returns></returns>
      public static bool operator !=(Producto v1, Producto v2)
      {
        return !(v1 == v2);

      }
  }
}
