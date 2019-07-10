using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trakingID;

        public Paquete(string direccionEntrega, string trakingID)
        {
            DireccionEntrega = direccionEntrega;
            TrakingID = trakingID;
        }

        #region #PROPIEDADES#

        public string DireccionEntrega { get; set; }
        public EEstado Estado { get; set; }

        public string TrakingID { get; set; }

        #endregion

        public void MockCicloDeVida()
        {
            Thread.Sleep(4000);
        }
        /// <summary>
        /// PUEDO TENER UN ERROR ACA.... MODIFIQUE EL TIPO DE PARAMETRO
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(Paquete elemento)
        {
            string cadena = String.Format("{0} para {1}", elemento.TrakingID, elemento.DireccionEntrega);

            return cadena;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" Direccion Entrega:" + DireccionEntrega);
            sb.AppendLine(" Estado:" + Estado);
            sb.AppendLine(" ID:" + TrakingID);

            return Convert.ToString(sb);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrakingID == p2.TrakingID) ? true : false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }


    }
}
