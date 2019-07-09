using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
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

        private void _ramdomClases()
        {
            int numero;

            numero = random.Next(3);
            clasesDelDia.Enqueue( (Universidad.EClases)numero );

            numero = random.Next(3);
            clasesDelDia.Enqueue((Universidad.EClases)numero);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in clasesDelDia)
            {
                sb.AppendLine("Clase del dia: " + item);
            }

            return Convert.ToString(sb);
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }


        protected override string ParticiparEnClase()
        {
            return "Clase del dia: " + clasesDelDia.Peek();
        }

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
