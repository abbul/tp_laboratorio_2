using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        public List<Paquete> Paquetes
        {
            get { return paquetes; }

            set { paquetes = value; }
        }

        public void FinEntregas()
        {
            foreach (Thread hilo in mockPaquetes)
            {
                hilo.Interrupt();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string cadena=null;

            foreach (Paquete item in elementos)
            {
                cadena+= String.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            }

            return cadena;
        }

        #region #OPERADORES#

        public static Correo operator +(Correo c, Paquete p)
        {

            if (c != p)
            {
                c.paquetes.Add(p);
            }
            else
            {
                throw new TrackingIdRepetidoException("El Traking ID " + p.TrakingID + "ya figura en la lista de envios");
            }

            return c;
        }

        public static bool operator ==(Correo c, Paquete p)
        {
            bool flag=false;

            foreach (Paquete item in c.Paquetes)
            {
                if (item.TrakingID == p.TrakingID)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Correo c, Paquete p)
        {
            return !(c == p);
        }

        #endregion


    }
}
