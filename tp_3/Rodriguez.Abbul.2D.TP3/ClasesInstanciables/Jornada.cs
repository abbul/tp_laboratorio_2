using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        private const string path = "C:/Users/AstrobertoAbbulRodri/Desktop/tp_laboratorio_2/tp_3/2017-TP3-Archivos/Jornada.txt";

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor): this()
        {
            Clase = clase;
            Instructor = instructor;
        }


        #region #PROPIEDADES#

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        public Universidad.EClases Clase { get; set; }
        public Profesor Instructor { get; set; }

        #endregion

        public static bool Guardar(Jornada jornada)
        {
            return Texto.Guardar(path, jornada.ToString());
        }

        public string Leer()
        {
            string buffer;
            Texto.Leer(path, out buffer);

            return buffer;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno item in j.alumnos)
            {
                if (item.Dni == a.Dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }

            return j;
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.AppendLine("CLASE DE " + clase + " POR " + Instructor.ToString());
            sb.AppendLine("ALUMNOS: ");

            foreach (Alumno item in alumnos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("<------------------------------------------->");

            return Convert.ToString(sb);
        }

    }
}
