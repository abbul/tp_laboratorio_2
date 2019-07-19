namespace Vista
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ltsEstadoEntregado = new System.Windows.Forms.ListBox();
            this.ltsEstadoViajando = new System.Windows.Forms.ListBox();
            this.ltsEstadoIngresado = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbMostrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ltsEstadoEntregado);
            this.groupBox1.Controls.Add(this.ltsEstadoViajando);
            this.groupBox1.Controls.Add(this.ltsEstadoIngresado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 574);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estados Paquetes";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(34, 380);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(547, 164);
            this.rtbMostrar.TabIndex = 7;
            this.rtbMostrar.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.mtxtTrackingID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnMostarTodos);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(609, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 164);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 116);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(155, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(21, 51);
            this.mtxtTrackingID.Mask = "000-000-0000";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(155, 22);
            this.mtxtTrackingID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Traking ID";
            // 
            // btnMostarTodos
            // 
            this.btnMostarTodos.Location = new System.Drawing.Point(197, 108);
            this.btnMostarTodos.Name = "btnMostarTodos";
            this.btnMostarTodos.Size = new System.Drawing.Size(95, 39);
            this.btnMostarTodos.TabIndex = 4;
            this.btnMostarTodos.Text = "Mostrar";
            this.btnMostarTodos.UseVisualStyleBackColor = true;
            this.btnMostarTodos.Click += new System.EventHandler(this.BtnMostarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(197, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 42);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ltsEstadoEntregado
            // 
            this.ltsEstadoEntregado.FormattingEnabled = true;
            this.ltsEstadoEntregado.ItemHeight = 16;
            this.ltsEstadoEntregado.Location = new System.Drawing.Point(642, 77);
            this.ltsEstadoEntregado.Name = "ltsEstadoEntregado";
            this.ltsEstadoEntregado.Size = new System.Drawing.Size(274, 260);
            this.ltsEstadoEntregado.TabIndex = 5;
            this.ltsEstadoEntregado.SelectedIndexChanged += new System.EventHandler(this.LtsEstadoEntregado_SelectedIndexChanged);
            // 
            // ltsEstadoViajando
            // 
            this.ltsEstadoViajando.FormattingEnabled = true;
            this.ltsEstadoViajando.ItemHeight = 16;
            this.ltsEstadoViajando.Location = new System.Drawing.Point(336, 77);
            this.ltsEstadoViajando.Name = "ltsEstadoViajando";
            this.ltsEstadoViajando.Size = new System.Drawing.Size(274, 260);
            this.ltsEstadoViajando.TabIndex = 4;
            // 
            // ltsEstadoIngresado
            // 
            this.ltsEstadoIngresado.FormattingEnabled = true;
            this.ltsEstadoIngresado.ItemHeight = 16;
            this.ltsEstadoIngresado.Location = new System.Drawing.Point(34, 77);
            this.ltsEstadoIngresado.Name = "ltsEstadoIngresado";
            this.ltsEstadoIngresado.Size = new System.Drawing.Size(274, 260);
            this.ltsEstadoIngresado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "En Viaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresado";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 625);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Abbul.Rodriguez.D";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPpal_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox ltsEstadoEntregado;
        private System.Windows.Forms.ListBox ltsEstadoViajando;
        private System.Windows.Forms.ListBox ltsEstadoIngresado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

