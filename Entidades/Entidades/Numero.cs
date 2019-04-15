using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        public string SetNumero
        {
            set
            {
               numero = ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            
        }

        public string BinarioDecimal(string binario)
        {
            decimal entero;
            bool flag;

            flag = decimal.TryParse(binario, out entero);
            
             return (flag==true) ? "Correcto" : "Valor Invalido";
        }

        public string DecimalBinario(double numero)
        {
            string cadena= Convert.ToString(numero);

            if( cadena == null )
            {
                return "Valor Invalido";
            }

            return "Correcto";
        }

        public string DecimalBinario(string numero)
        {
            string cadena = Convert.ToString(numero);

            if (cadena == null)
            {
                return "Valor Invalido";
            }

            return "Correcto";
        }


        public static double operator -(Numero n1, Numero n2)
        {
            return n1 - n2;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1 * n2;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            return n1 / n2;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1 + n2;
        }

        private double ValidarNumero(string strNumero)
        {
            double numero=0;

            double.TryParse(strNumero, out numero);

            return numero;
        }


    }
}
