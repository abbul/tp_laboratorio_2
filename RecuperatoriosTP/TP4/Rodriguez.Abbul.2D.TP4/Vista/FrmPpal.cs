using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmPpal : Form
    {
        private Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();
            mtxtTrackingID.Select();
            PaqueteDAO.eventoDeSQL += new PaqueteDAO.DelegadoSQL(MostrarMensajeDeError);

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string dirrecion = txtDireccion.Text;
                string id = mtxtTrackingID.Text;

                if (dirrecion.Length > 0 && id.Length == 12 )
                {
                    Paquete paquete = new Paquete(dirrecion, id);
                    paquete.InformarEstado += paq_InformaEstado;
                    correo += paquete;
                }
                else
                {
                    MessageBox.Show("Valor En Nulo o Incompleto");
                }
                
            }
            catch (TrackingIdRepetidoException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            ActualizarEstados();
        }

        private void ActualizarEstados()
        {
            ltsEstadoIngresado.Items.Clear();
            ltsEstadoViajando.Items.Clear();
            ltsEstadoEntregado.Items.Clear();

            foreach (Paquete item in correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        ltsEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        ltsEstadoViajando.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        ltsEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (sender is Exception)
            {
                MessageBox.Show(((Exception)sender).Message, "ERROR: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        private void FrmPpal_FormClosed(object sender, FormClosedEventArgs e)
        {
            correo.FinEntregas();
        }

        private void BtnMostarTodos_Click(object sender, EventArgs e)
        {
            MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\salida.txt";
                string retornaString = elemento.MostrarDatos(elemento);
                rtbMostrar.Text = retornaString;

                retornaString.Guardar(path);
            }
        }

        private void LtsEstadoEntregado_SelectedIndexChanged(object sender, EventArgs e)
        {

            MostrarInformacion<Paquete>((IMostrar<Paquete>)ltsEstadoEntregado.SelectedItem);

        }

        public void MostrarMensajeDeError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
