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
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paquete = new Paquete(txtDireccion.Text,mtxtTrackingID.Text);
            paquete.InformarEstado += paq_InformaEstado;

            try
            {
                correo += paquete;
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe ese Tracking ID. ID ingresado:" + mtxtTrackingID.Text);
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

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void FrmPpal_FormClosed(object sender, FormClosedEventArgs e)
        {
            correo.FinEntregas();
        }

        private void BtnMostarTodos_Click(object sender, EventArgs e)
        {
            MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void LtsEstadoIngresado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                string retornaString = elemento.MostrarDatos(elemento);
                rtbMostrar.Text = retornaString;

                retornaString.Guardar("salida.txt");
            }
        }

    }
}
