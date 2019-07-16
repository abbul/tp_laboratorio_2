namespace MainCorreo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEgresado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lstEgresado = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lstEnViaje = new System.Windows.Forms.ListBox();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTrakingId = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEgresado);
            this.groupBox1.Controls.Add(this.lblEnViaje);
            this.groupBox1.Controls.Add(this.lstEgresado);
            this.groupBox1.Controls.Add(this.lstEnViaje);
            this.groupBox1.Controls.Add(this.lblIngresado);
            this.groupBox1.Controls.Add(this.lstIngresado);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(967, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estados Paquetes";
            // 
            // lblEgresado
            // 
            this.lblEgresado.AutoSize = true;
            this.lblEgresado.Location = new System.Drawing.Point(616, 36);
            this.lblEgresado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgresado.Name = "lblEgresado";
            this.lblEgresado.Size = new System.Drawing.Size(74, 17);
            this.lblEgresado.TabIndex = 5;
            this.lblEgresado.Text = "Entregado";
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(307, 36);
            this.lblEnViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(60, 17);
            this.lblEnViaje.TabIndex = 4;
            this.lblEnViaje.Text = "En Viaje";
            // 
            // lstEgresado
            // 
            this.lstEgresado.ContextMenuStrip = this.contextMenuStrip1;
            this.lstEgresado.FormattingEnabled = true;
            this.lstEgresado.ItemHeight = 16;
            this.lstEgresado.Location = new System.Drawing.Point(620, 59);
            this.lstEgresado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEgresado.Name = "lstEgresado";
            this.lstEgresado.Size = new System.Drawing.Size(268, 244);
            this.lstEgresado.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem1.Text = "Mostrar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // lstEnViaje
            // 
            this.lstEnViaje.FormattingEnabled = true;
            this.lstEnViaje.ItemHeight = 16;
            this.lstEnViaje.Location = new System.Drawing.Point(311, 59);
            this.lstEnViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEnViaje.Name = "lstEnViaje";
            this.lstEnViaje.Size = new System.Drawing.Size(268, 244);
            this.lstEnViaje.TabIndex = 2;
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(8, 36);
            this.lblIngresado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(71, 17);
            this.lblIngresado.TabIndex = 1;
            this.lblIngresado.Text = "Ingresado";
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.ItemHeight = 16;
            this.lstIngresado.Location = new System.Drawing.Point(8, 59);
            this.lstIngresado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(268, 244);
            this.lstIngresado.TabIndex = 0;
            this.lstIngresado.SelectedIndexChanged += new System.EventHandler(this.LstIngresado_SelectedIndexChanged);
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(24, 343);
            this.rtbMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(571, 117);
            this.rtbMostrar.TabIndex = 4;
            this.rtbMostrar.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTrackingID);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.lblTrakingId);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(612, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(371, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            // 
            // txtTrackingID
            // 
            this.txtTrackingID.Location = new System.Drawing.Point(8, 42);
            this.txtTrackingID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrackingID.Mask = "000-000-0000";
            this.txtTrackingID.Name = "txtTrackingID";
            this.txtTrackingID.Size = new System.Drawing.Size(215, 22);
            this.txtTrackingID.TabIndex = 13;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(4, 79);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTrakingId
            // 
            this.lblTrakingId.AutoSize = true;
            this.lblTrakingId.Location = new System.Drawing.Point(4, 25);
            this.lblTrakingId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrakingId.Name = "lblTrakingId";
            this.lblTrakingId.Size = new System.Drawing.Size(73, 17);
            this.lblTrakingId.TabIndex = 4;
            this.lblTrakingId.Text = "Traking ID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(4, 98);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(219, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(232, 89);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(111, 34);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(232, 38);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(967, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Popolo Leonardo 2A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEgresado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.ListBox lstEnViaje;
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtTrackingID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTrakingId;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstEgresado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    }
}

