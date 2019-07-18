using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    

    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public Paquete(string direccionEntrega, string trakingID)
        {
            DireccionEntrega = direccionEntrega;
            TrackingID = trakingID;
        }

        #region #PROPIEDADES#

        public string DireccionEntrega {
            get { return direccionEntrega;  }
            set { direccionEntrega = value;  }
        }
        public EEstado Estado {
            get { return estado; }
            set { estado = value; }
        }

        public string TrackingID {
            get { return trackingID; }
            set { trackingID = value; }
        }

        #endregion

        public void MockCicloDeVida()
        {
            try
            {
                do
                {
                    switch (estado)
                    {
                        case EEstado.Ingresado:
                            Thread.Sleep(4000);
                            estado = EEstado.EnViaje;
                            InformarEstado(this, new EventArgs());
                            break;

                        case EEstado.EnViaje:
                            Thread.Sleep(4000);
                            estado = EEstado.Entregado;
                            InformarEstado(this, new EventArgs());
                            break;
                    }

                } while (estado != EEstado.Entregado);

                PaqueteDAO.Insertar(this);
            }
            catch (Exception error)
            {
                Notifica.Send( error.Message,ETipoExcepcion.sql );
            }

        }
        /// <summary>
        /// FIJARME SI ESTA BIEN, NO ESTOY SEGURO
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete paquete = (Paquete)elemento;
            string cadena = String.Format("{0} para {1}", paquete.TrackingID, paquete.DireccionEntrega);

            return cadena;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrackingID == p2.TrackingID) ? true : false;
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

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;

    }
}
