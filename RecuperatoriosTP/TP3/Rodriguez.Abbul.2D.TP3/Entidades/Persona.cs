using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private int dni;

        public string Nombre {
            get { return nombre;  }

            set {

                if( validaString(value) )
                {
                    nombre = value;
                }
                else
                {
                    throw new StringInvalidoException("Solo debe ingresar letras: " + value);
                }
            }
        }
        public string Apellido
        {
            get { return apellido; }

            set
            {
                if (validaString(value))
                {
                    apellido = value;
                }
                else
                {
                    throw new StringInvalidoException("Solo debe ingresar letras: "+value);
                }
            }
        }
        public string Nacionalidad { get; set; }
        public int Dni {
            get { return dni; }
            set
            {
                if (value>0)
                {
                    if (this.nacionalidad == "argentina" && value >= 1 && value <= 89999999 )
                    {
                        dni = value;
                    }
                    else if (this.nacionalidad != "argentina" && value >=90000000 && value <=99999999)
                    {
                        dni = value;
                    }
                    else
                    {
                        throw new DniInvalidoException("DNI no corresponde con la nacionalidad");
                    }
                }
                else
                {
                    throw new DniInvalidoException("DNI debe ser mayor a 0");
                }
            }
        }

        private static bool validaString(string cadena)
        {
            bool resultado = Regex.IsMatch(cadena, @"^[a-zA-Z]+$");

            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Nombre:" + Nombre);
            datos.AppendLine("Apellido:" + Apellido);
            datos.AppendLine("Nacionalidad:" + Nacionalidad);
            datos.AppendLine("Dni:" + Dni);

            return Convert.ToString(datos);
        }

    }
}
