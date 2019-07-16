using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
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
            double.TryParse(strNumero, out this.numero);
        }

        public string BinarioDecimal(string binario)
        {
            int i;
            int entero = 0;
            string returnAux = "";

            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return "Valor no binario";
                }
                    
            }
                

            if (binario == "" || ReferenceEquals(binario, null))
            {
                returnAux = "Valor inválido";
            }
            else
            {
                for (i = 1; i <= binario.Length; i++)
                {
                    entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
                }
                returnAux = entero.ToString();
            }

            return returnAux;
        }

        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        public string DecimalBinario(string numero)
        {
            int entero;
            string salida= "";

            if (int.TryParse(numero, out entero))
            {
                if(entero>0)
                {

                    while (entero > 0)
                    {
                        salida = (entero % 2).ToString() + salida;
                        entero = entero / 2;
                    }

                    return salida;
                }

                else if(entero==0)
                {
                    return "0";
                }
                else
                {
                    return "Debe ser >= 0";
                }
                
            }

            return "Valor Invalido";
        }


        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero==0)
            {
                return double.MaxValue;
            }
            return n1.numero / n2.numero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        private double ValidarNumero(string strNumero)
        {
            double numero=0;

            double.TryParse(strNumero, out numero);

            return numero;
        }


    }
}
