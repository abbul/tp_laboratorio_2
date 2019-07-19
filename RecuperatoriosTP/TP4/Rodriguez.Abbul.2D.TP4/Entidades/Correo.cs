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
                hilo.Abort();
            }
        }

        /// <summary>
        /// PUEDO TENER UN ERROR; validar
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string cadena=null;
            Correo correo = (Correo)elementos;

            foreach (Paquete item in correo.paquetes)
            {
                cadena+= String.Format("{0} para {1} ({2}) \n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString());
            }

            return cadena;
        }

        #region #OPERADORES#

        public static Correo operator +(Correo c, Paquete p)
        {
            try
            {
                if (c != p)
                {
                    c.paquetes.Add(p);
                    Thread hiloDelPaquete = new Thread(p.MockCicloDeVida);
                    c.mockPaquetes.Add(hiloDelPaquete);
                    hiloDelPaquete.Start();
                }
                else
                {
                    throw new TrackingIdRepetidoException("El Traking ID: '" + p.TrackingID + "' ya figura en la lista de envios");
                }
            }

            catch (Exception error)
            {
                throw error;
            }

            return c;
        }

        public static bool operator ==(Correo c, Paquete p)
        {
            bool flag=false;

            foreach (Paquete item in c.Paquetes)
            {
                if (item.TrackingID == p.TrackingID)
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
