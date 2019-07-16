using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    /// <summary>
    /// Clase abstract, suele ser clase padre de Universitario
    /// </summary>
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;

        protected Persona()
        {
        }

        protected Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        protected Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad )
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            Dni = dni;
        }

        protected Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
            StringToDNI = dni;
        }


        public string Nombre {
            get { return nombre;  }

            set {

                if(ValidaNombreApellido(value) )
                {
                    nombre = value;
                }
            }
        }
        public string Apellido
        {
            get { return apellido; }

            set
            {
                if (ValidaNombreApellido(value))
                {
                    apellido = value;
                }
            }
        }
        public ENacionalidad Nacionalidad { get; set; }

        public int Dni {
            get { return dni; }
            set
            {
                int flag = ValidaDni(this.Nacionalidad, value);

                if ( flag == 1)
                {
                    dni = value;
                }
                else if (flag == 0)
                {
                    throw new NacionalidadInvalidaException("La Nacionalidad no se condice con numero de DNI");
                }
                else
                {
                    throw new DniInvalidoException("DNI invalido");
                }
            }
        }

        public string StringToDNI {
            set {

                int valor = ValidaDni(this.Nacionalidad, value);

                Dni = valor;
            }
        }

        /// <summary>
        /// Valida que el nombre y apellido solo contengan letras
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        private static bool ValidaNombreApellido(string cadena)
        {
            bool resultado = Regex.IsMatch(cadena, @"^[a-zA-Z]+$");

            return resultado;
        }

        /// <summary>
        /// mostramos todos los datos del objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("NOMBRE COMPLETO: " + Apellido + " , " + Nombre);
            datos.AppendLine("NACIONALIDAD:" + Nacionalidad);

            return Convert.ToString(datos);
        }

        /// <summary>
        /// valida que el dni cumpla con los parametros logicos
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidaDni(ENacionalidad nacionalidad, int dato)
        {
            int salida;

            if (dato >= 1 && dato<= 99999999)
            {
                if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999)
                {
                    salida = 1;
                }
                else if (nacionalidad != ENacionalidad.Argentino && dato >= 90000000 && dato <= 99999999)
                {
                    salida = 1;
                }
                else
                {
                    salida = 0;
                }
            }
            else
            {
                salida= -1;
            }

            return salida;
        }

        /// <summary>
        /// valida que el dni cumpla con los parametros logicos
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidaDni(ENacionalidad nacionalidad, string dato)
        {
            int salida;
            int dni;

            bool validaInt = Regex.IsMatch(dato, @"^[0-9]+$");
            bool parseInt = int.TryParse(dato, out dni);

            if (validaInt && parseInt && dato.Length >= 1 && dato.Length <= 10 )
            {
               salida = dni;
            }
            else
            {
                salida = -1;
            }

            return salida;
        }

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

    }
}
