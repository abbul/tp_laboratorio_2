using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Hereda de Universitario y Persona
    /// </summary>
    public class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        private Profesor()
        {
            
        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _ramdomClases();
        }

        /// <summary>
        /// Cargan de forma ramdom 2 clases al profesor
        /// </summary>
        private void _ramdomClases()
        {
            int numero;

            numero = random.Next(3);
            clasesDelDia.Enqueue( (Universidad.EClases)numero );

            numero = random.Next(3);
            clasesDelDia.Enqueue((Universidad.EClases)numero);
        }

        /// <summary>
        /// Mostrara todas las clases que del dia para ese profesor
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in clasesDelDia)
            {
                sb.AppendLine("Clase del dia: " + item);
            }

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Son iguales si el profesor da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            if ( !ReferenceEquals(null, i) )
            {
                foreach (Universidad.EClases item in i.clasesDelDia)
                {
                    if (item == clase)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        /// <summary>
        /// Muestra la primera clase de la cola de clases.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return "Clase del dia: " + clasesDelDia.Peek();
        }

        /// <summary>
        /// Muestra absolutamente todos los datos del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Clases del dia: ");

            foreach (Universidad.EClases item in clasesDelDia)
            {
                sb.AppendLine(Convert.ToString(item));
            }

            return Convert.ToString(sb);
        }
    }
}
