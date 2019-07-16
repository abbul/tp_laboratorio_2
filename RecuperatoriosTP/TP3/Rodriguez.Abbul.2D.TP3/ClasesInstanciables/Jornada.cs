using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;


namespace EntidadesInstanciables
{
    /// <summary>
    /// Hace referencia a una clase que se dicta en el universidad
    /// </summary>
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        private const string path="../../../Jornada.txt";
        

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor): this()
        {
            try
            {
                Clase = clase;
                Instructor = instructor;
            }
            catch (SinProfesorException e)
            {
                throw new SinProfesorException();
            }
            
        }

        #region #PROPIEDADES#

        public List<Alumno> Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }
        public Universidad.EClases Clase { get; set; }
        public Profesor Instructor {

            get { return instructor; }
            set
            {
                if (value == Clase)
                {
                    instructor = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }

        #endregion

        /// <summary>
        /// Guardar los datos de un archivo de texto
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            bool salida = false;

            try
            {
                salida= Texto.Guardar(path, jornada.ToString());
            }
            catch (ArchivosException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return salida;

        }

        /// <summary>
        /// Lee los datos de un archivo de texto.
        /// </summary>
        /// <returns></returns>
        public string Leer()
        {
            string buffer=null;

            try
            {
                Texto.Leer(path, out buffer);
                
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return buffer;
        }

        /// <summary>
        /// Son iguales solo si el alumno ya esta viendo esa clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna todos los datos de la jornada. Profesor y alumnos cursando
        /// </summary>
        /// <returns></returns>
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
