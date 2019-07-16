using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using EntidadesInstanciables;
using Archivos;

namespace EntidadesInstanciables
{
    /// <summary>
    /// Clase principal del proyecto
    /// </summary>
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        private const string path = "../../../Jornada.txt";

        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornadas = new List<Jornada>();
            profesores = new List<Profesor>();
        }

        #region #PROPIEDADES#
        public List<Alumno> Alumnos {

            get { return alumnos; }
            set { alumnos = value; }
        }
        public List<Jornada> Jornadas
        {
            get { return jornadas; }
            set { jornadas = value; }
        }
        public List<Profesor> Instructores {

            get { return profesores; }
            set { profesores = value; }
        }
        public Jornada this[int i] {

            get {
                return jornadas[i];
            }

            set {

                    jornadas[i] = value;                
            }
        }

        #endregion

        /// <summary>
        /// Muestra todos los datos de la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\t --------JORNADA-------");

            foreach (var item in jornadas)
            {
                sb.AppendLine(item.ToString());
            }

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Muestra los datos basicos
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre:");

            return Convert.ToString(sb);
        }

        /// <summary>
        /// Son iguales sin el almuno esta en la lista de la universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="alu"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad uni, Alumno alu)
        {
            foreach (Alumno item in uni.Alumnos)
            {
                if (item == alu)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Universidad uni, Alumno alu)
        {
            return !(uni == alu);
        }

        /// <summary>
        /// Agrega un alumno solo sino existe en la lista
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="alu"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad uni, Alumno alu)
        {

            if (uni != alu)
            {
                uni.alumnos.Add(alu);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return uni;
        }

        /// <summary>
        /// Son distintos sin el DNi cambia
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="profe"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad uni, Profesor profe)
        {
  
            foreach (Profesor item in uni.Instructores)
            {
                if (item.Dni == profe.Dni)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Universidad uni, Profesor profe)
        {
            return !(uni == profe);
        }

        /// <summary>
        /// Agregara a un profesor solo si el profesor no existe en la lista
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="profe"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad uni, Profesor profe)
        {
            if (uni != profe)
            {
                uni.Instructores.Add(profe);
            }

            return uni;
        }

        /// <summary>
        /// Son iguales si uno de los profesores da esa clase
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad uni, EClases clase)
        {

                Profesor profe = null;

                foreach (Profesor item in uni.Instructores)
                {
                    if (item == clase)
                    {
                        profe = item;
                    }
                }

                return profe;
        }

        public static Profesor operator !=(Universidad uni, EClases clase)
        {
            Profesor profe = null;

            foreach (Profesor item in uni.Instructores)
            {
                if (item != clase)
                {
                    profe = item;
                }
            }

            return profe;
        }

        /// <summary>
        /// Agregagamos uns jornada con un profesor q de esa clases y todos los alumnos q cursen esa clase
        /// </summary>
        /// <param name="uni"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad uni, EClases clase)
        {
            try
            {
                Profesor profe = (uni == clase);
                Jornada jornada = new Jornada(clase, profe);

                foreach (Alumno alumno in uni.Alumnos)
                {
                    if (alumno == clase)
                    {
                        jornada+= alumno;
                    }
                }

                uni.Jornadas.Add(jornada);

            }
            catch (SinProfesorException e)
            {
                throw e;
            }

            return uni;
        }

        public static bool Guardar(Universidad uni)
        {

            bool salida = false;

            try
            {
                salida = Texto.Guardar(path, uni.ToString());
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

        public Universidad Leer()
        {
            Xml<Universidad> readerImporter = new Xml<Universidad>();
            Universidad retorno=null;

            try
            {
                readerImporter.Leer(path, out retorno);

            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return retorno;

        }

        public enum EClases
        {
            Programacion=0,
            Laboratorio,
            Legislacion,
            SPD
        }

    }
}
