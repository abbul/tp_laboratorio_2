using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{   
    /// <summary>
    /// Clase abstract, hija de Persona
    /// </summary>
    public abstract class Universitario : Persona
    {
        private int legajo;

        protected Universitario()
        {
        }

        protected Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) :
            base(nombre, apellido, dni, nacionalidad)
        {
            try
            {
                this.legajo = legajo;
            }
            catch (NacionalidadInvalidaException e)
            {
                throw e;
            }
            catch (DniInvalidoException e)
            {
                throw e;
            }

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>
        /// muestra solo los atributos declarados en este objecto.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo Numero: " + legajo);

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Seran iguales solo si son del mismo tipo y si el DNI ó Legajo son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool flag=false;

           if( pg1.GetType() == pg2.GetType() )
            {
                if ( pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni )
                {
                    flag =  true;
                }
            }

            return flag;
        }

        public static bool operator !=(Universitario uno, Universitario dos)
        {
            return !(uno == dos);
        }

        protected abstract string ParticiparEnClase();


    }
}
