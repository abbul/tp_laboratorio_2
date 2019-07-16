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

namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.SelectedItem = "+";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero uno = new Numero(txtNumero1.Text);
            Numero dos = new Numero(txtNumero2.Text);
            lblTitulo.TabIndex = 10;

            lblResultado.Text = Convert.ToString( Calculadora.Operar(uno, dos, cmbOperador.Text) );
     
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            cmbOperador.Text = "+";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if(lblTitulo.TabIndex == 10) // significa q ya operaron
            {
                Numero numero = new Numero();
                lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
                lblTitulo.TabIndex = 11;
            }
            else if (lblTitulo.TabIndex == 11)
            {
                MessageBox.Show("Ya es Binario");
            }
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblTitulo.TabIndex == 11) // significa q es binario
            {
                Numero numero = new Numero();
                lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
                lblTitulo.TabIndex = 10;
            }
            else if(lblTitulo.TabIndex == 10)
            {
                MessageBox.Show("Ya es Decimal");
            }
        }
    }
}
