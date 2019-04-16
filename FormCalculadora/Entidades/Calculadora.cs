using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        static public double Operar(Numero uno, Numero dos, string operador)
        {
            string dato= ValidarOperador(operador);

            switch(dato)
            {
                case "+":
                    return uno + dos;
                case "-":
                    return uno -  dos;
                case "/":
                    return uno - dos;
                case "*":
                    return uno - dos;
                default:
                    return 0;
            }
        }

        static private string ValidarOperador(string operador)
        {
            return (operador == "+" || operador == "-" || operador == "/" || operador == "*") ? operador : "+";
        }

    }
}
