using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Changuito
    {
        private List<Producto> productos;
        private int capacidad;

        /// <summary>
        /// Todos los tipos de productos posibles.
        /// </summary>
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region "Constructores"
        /// <summary>
        /// Creamos una lista de productos.
        /// </summary>
        private Changuito()
        {
            productos = new List<Producto>();
        }

        /// <summary>
        /// Indicamos la capacidad maxima de productos que tendra nuestro Changuito
        /// </summary>
        /// <param name="capacidad"></param>
        public Changuito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el Changuito y todos los Productos que tenga
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del changuito y sus elementos (solo del tipo requerido).
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos predicatede ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            List<Producto> varios = ( Convert.ToString(tipo) == "Todos") ? c.productos : c.productos.FindAll(x => x.GetType().Name == Convert.ToString(tipo));
            
            sb.AppendFormat("INFORMACION: Tenemos {0} lugares ocupados de un total de {1} posibles \n\n", c.productos.Count, c.capacidad);

            foreach (Producto item in varios )
            {
                sb.AppendLine(item.Mostrar);
            }

            return Convert.ToString(sb);

        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un producto a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns></returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if (c.productos.Count < c.capacidad)
            {
                foreach (Producto item in c.productos)
                {
                    if (item == p)
                    {
                        return c;
                    }

                }

                c.productos.Add(p);
            }
            

            return c;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns>El Changuito</returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            foreach (Producto item in c.productos.ToList() )
            {
                if (item == p)
                {
                    c.productos.Remove(p);
                    return c;
                }   
            }

            return c;
        }
        #endregion
    }
}
