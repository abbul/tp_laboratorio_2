using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Hereda de Universitario y Persona
    /// </summary>
    public class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {
            try
            {

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

        public Alumno(int id,string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            try
            {
               
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

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            try
            {
                this.claseQueToma = claseQueToma;
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

        /// <summary>
        /// muestra solo los atributos declarados en este objecto.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Clase: " + claseQueToma);
            sb.AppendLine("Estado de Cuenta: " + estadoCuenta);

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Seran iguales solo si el alumno esta en esa clase y si no es un deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor ) ? true : false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        /// <summary>
        /// Retorna la clase que toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return Convert.ToString(claseQueToma);
        }

        /// <summary>
        /// Retorna las propiedades declaradas en este objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("ESTADO DE CUENTA: " + estadoCuenta);
            sb.AppendLine("TOMA CLASE DE: " + claseQueToma);
            

            return Convert.ToString(sb);
        }
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }

}
