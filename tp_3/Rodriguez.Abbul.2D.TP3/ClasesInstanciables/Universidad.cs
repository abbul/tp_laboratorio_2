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
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        private const string path = "C:/Users/AstrobertoAbbulRodri/Desktop/tp_laboratorio_2/tp_3/2017-TP3-Archivos/Universidad.xml";

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
        public List<Profesor> Profesores {

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

        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre:");

            return Convert.ToString(sb);
        }

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

        public static bool operator ==(Universidad uni, Profesor profe)
        {
  
            foreach (Profesor item in uni.Profesores)
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

        public static Universidad operator +(Universidad uni, Profesor profe)
        {
            if (uni != profe)
            {
                uni.Profesores.Add(profe);
            }

            return uni;
        }

        public static Profesor operator ==(Universidad uni, EClases clase)
        {
            bool flag = false;
            Profesor profe=null;

            foreach (Profesor item in uni.Profesores)
            {
                if (item == clase)
                {
                    profe = item;
                    flag = true;
                }
            }

            if (flag)
            {
                return profe;
            }
            else
            {
                throw new SinProfesorException();
            }

        }

        public static Profesor operator !=(Universidad uni, EClases clase)
        {
            Profesor profe = null;

            foreach (Profesor item in uni.Profesores)
            {
                if (item != clase)
                {
                    profe = item;
                }
            }

            return profe;
        }

        public static Universidad operator +(Universidad uni, EClases clase)
        {
            try
            {
                Profesor profe = uni == clase;
                Jornada jornada = new Jornada(clase, profe);

                foreach (Alumno item in uni.Alumnos)
                {
                    if (item == clase)
                    {
                        jornada+= item;
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
            return Texto.Guardar(path, uni.ToString());
        }

        public Universidad Leer()
        {
            Xml<Universidad> readerImporter = new Xml<Universidad>();
            Universidad retorno;

            readerImporter.Leer(path, out retorno);

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
