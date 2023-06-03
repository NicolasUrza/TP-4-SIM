namespace TP_4_SIM_Aeropuerto
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnParametros = new Panel();
            txtMediaCarga = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtAerolineaB = new TextBox();
            label3 = new Label();
            txtAerolineaA = new TextBox();
            label1 = new Label();
            txtIntencionMuelle = new TextBox();
            lblCarga = new Label();
            btnGenerarSimulacion = new Button();
            txtIntencionCarga = new TextBox();
            lblIntención = new Label();
            txtMediaMuelle = new TextBox();
            lblMuelle = new Label();
            txtAterrizaje = new TextBox();
            lblAterrizaje = new Label();
            txtLlegadaAvion = new TextBox();
            lblLLegadaAviones = new Label();
            txtDesde = new TextBox();
            lblMostrarDesde = new Label();
            txtCantIteraciones = new TextBox();
            lblCantIteraciones = new Label();
            pnSolucion = new Panel();
            pnParametros.SuspendLayout();
            SuspendLayout();
            // 
            // pnParametros
            // 
            pnParametros.BorderStyle = BorderStyle.FixedSingle;
            pnParametros.Controls.Add(txtMediaCarga);
            pnParametros.Controls.Add(label5);
            pnParametros.Controls.Add(label4);
            pnParametros.Controls.Add(label2);
            pnParametros.Controls.Add(txtAerolineaB);
            pnParametros.Controls.Add(label3);
            pnParametros.Controls.Add(txtAerolineaA);
            pnParametros.Controls.Add(label1);
            pnParametros.Controls.Add(txtIntencionMuelle);
            pnParametros.Controls.Add(lblCarga);
            pnParametros.Controls.Add(btnGenerarSimulacion);
            pnParametros.Controls.Add(txtIntencionCarga);
            pnParametros.Controls.Add(lblIntención);
            pnParametros.Controls.Add(txtMediaMuelle);
            pnParametros.Controls.Add(lblMuelle);
            pnParametros.Controls.Add(txtAterrizaje);
            pnParametros.Controls.Add(lblAterrizaje);
            pnParametros.Controls.Add(txtLlegadaAvion);
            pnParametros.Controls.Add(lblLLegadaAviones);
            pnParametros.Controls.Add(txtDesde);
            pnParametros.Controls.Add(lblMostrarDesde);
            pnParametros.Controls.Add(txtCantIteraciones);
            pnParametros.Controls.Add(lblCantIteraciones);
            pnParametros.Dock = DockStyle.Top;
            pnParametros.Location = new Point(0, 0);
            pnParametros.Margin = new Padding(3, 4, 3, 4);
            pnParametros.Name = "pnParametros";
            pnParametros.Size = new Size(1125, 267);
            pnParametros.TabIndex = 0;
            // 
            // txtMediaCarga
            // 
            txtMediaCarga.BackColor = Color.FromArgb(191, 191, 217);
            txtMediaCarga.Location = new Point(393, 148);
            txtMediaCarga.Margin = new Padding(3, 4, 3, 4);
            txtMediaCarga.Name = "txtMediaCarga";
            txtMediaCarga.Size = new Size(114, 27);
            txtMediaCarga.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(230, 230, 240);
            label5.Location = new Point(250, 145);
            label5.Name = "label5";
            label5.Size = new Size(137, 22);
            label5.TabIndex = 23;
            label5.Text = "Media Carga: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(230, 230, 240);
            label4.Location = new Point(29, 223);
            label4.Name = "label4";
            label4.Size = new Size(237, 22);
            label4.TabIndex = 22;
            label4.Text = "Llegada Avion Aerolinea:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 230, 240);
            label2.Location = new Point(394, 223);
            label2.Name = "label2";
            label2.Size = new Size(30, 22);
            label2.TabIndex = 21;
            label2.Text = "B:";
            // 
            // txtAerolineaB
            // 
            txtAerolineaB.BackColor = Color.FromArgb(191, 191, 217);
            txtAerolineaB.Location = new Point(429, 221);
            txtAerolineaB.Margin = new Padding(3, 4, 3, 4);
            txtAerolineaB.Name = "txtAerolineaB";
            txtAerolineaB.Size = new Size(68, 27);
            txtAerolineaB.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(230, 230, 240);
            label3.Location = new Point(246, 223);
            label3.Name = "label3";
            label3.Size = new Size(30, 22);
            label3.TabIndex = 19;
            label3.Text = "A:";
            // 
            // txtAerolineaA
            // 
            txtAerolineaA.BackColor = Color.FromArgb(191, 191, 217);
            txtAerolineaA.Location = new Point(280, 221);
            txtAerolineaA.Margin = new Padding(3, 4, 3, 4);
            txtAerolineaA.Name = "txtAerolineaA";
            txtAerolineaA.Size = new Size(68, 27);
            txtAerolineaA.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 230, 240);
            label1.Location = new Point(355, 184);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 17;
            label1.Text = "Muelle:";
            // 
            // txtIntencionMuelle
            // 
            txtIntencionMuelle.BackColor = Color.FromArgb(191, 191, 217);
            txtIntencionMuelle.Location = new Point(429, 183);
            txtIntencionMuelle.Margin = new Padding(3, 4, 3, 4);
            txtIntencionMuelle.Name = "txtIntencionMuelle";
            txtIntencionMuelle.Size = new Size(68, 27);
            txtIntencionMuelle.TabIndex = 16;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarga.ForeColor = Color.FromArgb(230, 230, 240);
            lblCarga.Location = new Point(207, 183);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(72, 22);
            lblCarga.TabIndex = 15;
            lblCarga.Text = "Carga:";
            // 
            // btnGenerarSimulacion
            // 
            btnGenerarSimulacion.Cursor = Cursors.Hand;
            btnGenerarSimulacion.FlatAppearance.BorderColor = Color.FromArgb(230, 230, 240);
            btnGenerarSimulacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(230, 230, 240);
            btnGenerarSimulacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(14, 15, 22);
            btnGenerarSimulacion.FlatStyle = FlatStyle.Flat;
            btnGenerarSimulacion.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerarSimulacion.ForeColor = Color.FromArgb(230, 230, 240);
            btnGenerarSimulacion.Location = new Point(887, 52);
            btnGenerarSimulacion.Margin = new Padding(3, 4, 3, 4);
            btnGenerarSimulacion.Name = "btnGenerarSimulacion";
            btnGenerarSimulacion.Size = new Size(187, 175);
            btnGenerarSimulacion.TabIndex = 14;
            btnGenerarSimulacion.Text = "Generar";
            btnGenerarSimulacion.UseVisualStyleBackColor = true;
            btnGenerarSimulacion.Click += btnGenerarSimulacion_Click;
            // 
            // txtIntencionCarga
            // 
            txtIntencionCarga.BackColor = Color.FromArgb(191, 191, 217);
            txtIntencionCarga.Location = new Point(280, 184);
            txtIntencionCarga.Margin = new Padding(3, 4, 3, 4);
            txtIntencionCarga.Name = "txtIntencionCarga";
            txtIntencionCarga.Size = new Size(68, 27);
            txtIntencionCarga.TabIndex = 11;
            // 
            // lblIntención
            // 
            lblIntención.AutoSize = true;
            lblIntención.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIntención.ForeColor = Color.FromArgb(230, 230, 240);
            lblIntención.Location = new Point(113, 184);
            lblIntención.Name = "lblIntención";
            lblIntención.Size = new Size(94, 22);
            lblIntención.TabIndex = 10;
            lblIntención.Text = "Intención";
            // 
            // txtMediaMuelle
            // 
            txtMediaMuelle.BackColor = Color.FromArgb(191, 191, 217);
            txtMediaMuelle.Location = new Point(394, 109);
            txtMediaMuelle.Margin = new Padding(3, 4, 3, 4);
            txtMediaMuelle.Name = "txtMediaMuelle";
            txtMediaMuelle.Size = new Size(114, 27);
            txtMediaMuelle.TabIndex = 9;
            // 
            // lblMuelle
            // 
            lblMuelle.AutoSize = true;
            lblMuelle.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMuelle.ForeColor = Color.FromArgb(230, 230, 240);
            lblMuelle.Location = new Point(250, 107);
            lblMuelle.Name = "lblMuelle";
            lblMuelle.Size = new Size(140, 22);
            lblMuelle.TabIndex = 8;
            lblMuelle.Text = "Media Muelle: ";
            // 
            // txtAterrizaje
            // 
            txtAterrizaje.BackColor = Color.FromArgb(191, 191, 217);
            txtAterrizaje.Location = new Point(394, 70);
            txtAterrizaje.Margin = new Padding(3, 4, 3, 4);
            txtAterrizaje.Name = "txtAterrizaje";
            txtAterrizaje.Size = new Size(114, 27);
            txtAterrizaje.TabIndex = 7;
            // 
            // lblAterrizaje
            // 
            lblAterrizaje.AutoSize = true;
            lblAterrizaje.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAterrizaje.ForeColor = Color.FromArgb(230, 230, 240);
            lblAterrizaje.Location = new Point(225, 68);
            lblAterrizaje.Name = "lblAterrizaje";
            lblAterrizaje.Size = new Size(166, 22);
            lblAterrizaje.TabIndex = 6;
            lblAterrizaje.Text = "Media Aterrizaje:";
            // 
            // txtLlegadaAvion
            // 
            txtLlegadaAvion.BackColor = Color.FromArgb(191, 191, 217);
            txtLlegadaAvion.Location = new Point(394, 27);
            txtLlegadaAvion.Margin = new Padding(3, 4, 3, 4);
            txtLlegadaAvion.Name = "txtLlegadaAvion";
            txtLlegadaAvion.Size = new Size(114, 27);
            txtLlegadaAvion.TabIndex = 5;
            // 
            // lblLLegadaAviones
            // 
            lblLLegadaAviones.AutoSize = true;
            lblLLegadaAviones.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLLegadaAviones.ForeColor = Color.FromArgb(230, 230, 240);
            lblLLegadaAviones.Location = new Point(171, 31);
            lblLLegadaAviones.Name = "lblLLegadaAviones";
            lblLLegadaAviones.Size = new Size(226, 22);
            lblLLegadaAviones.TabIndex = 4;
            lblLLegadaAviones.Text = "Media Llegada Aviones:";
            // 
            // txtDesde
            // 
            txtDesde.BackColor = Color.FromArgb(191, 191, 217);
            txtDesde.Location = new Point(741, 66);
            txtDesde.Margin = new Padding(3, 4, 3, 4);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(114, 27);
            txtDesde.TabIndex = 3;
            // 
            // lblMostrarDesde
            // 
            lblMostrarDesde.AutoSize = true;
            lblMostrarDesde.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMostrarDesde.ForeColor = Color.FromArgb(230, 230, 240);
            lblMostrarDesde.Location = new Point(554, 67);
            lblMostrarDesde.Name = "lblMostrarDesde";
            lblMostrarDesde.Size = new Size(155, 22);
            lblMostrarDesde.TabIndex = 2;
            lblMostrarDesde.Text = "Mostrar Desde: ";
            // 
            // txtCantIteraciones
            // 
            txtCantIteraciones.BackColor = Color.FromArgb(191, 191, 217);
            txtCantIteraciones.Location = new Point(741, 28);
            txtCantIteraciones.Margin = new Padding(3, 4, 3, 4);
            txtCantIteraciones.Name = "txtCantIteraciones";
            txtCantIteraciones.Size = new Size(114, 27);
            txtCantIteraciones.TabIndex = 1;
            // 
            // lblCantIteraciones
            // 
            lblCantIteraciones.AutoSize = true;
            lblCantIteraciones.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantIteraciones.ForeColor = Color.FromArgb(230, 230, 240);
            lblCantIteraciones.Location = new Point(509, 28);
            lblCantIteraciones.Name = "lblCantIteraciones";
            lblCantIteraciones.Size = new Size(239, 22);
            lblCantIteraciones.TabIndex = 0;
            lblCantIteraciones.Text = "Cantidad de Iteraciones: ";
            // 
            // pnSolucion
            // 
            pnSolucion.BackColor = Color.FromArgb(28, 30, 40);
            pnSolucion.Dock = DockStyle.Fill;
            pnSolucion.Location = new Point(0, 267);
            pnSolucion.Margin = new Padding(3, 4, 3, 4);
            pnSolucion.Name = "pnSolucion";
            pnSolucion.Size = new Size(1125, 481);
            pnSolucion.TabIndex = 1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(1125, 748);
            Controls.Add(pnSolucion);
            Controls.Add(pnParametros);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Aeropuerto";
            Load += Principal_Load;
            pnParametros.ResumeLayout(false);
            pnParametros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnParametros;
        private Button btnGenerarSimulacion;
        private TextBox txtIntencionCarga;
        private Label lblIntención;
        private TextBox txtMediaMuelle;
        private Label lblMuelle;
        private TextBox txtAterrizaje;
        private Label lblAterrizaje;
        private TextBox txtLlegadaAvion;
        private Label lblLLegadaAviones;
        private TextBox txtDesde;
        private Label lblMostrarDesde;
        private TextBox txtCantIteraciones;
        private Label lblCantIteraciones;
        private Label label4;
        private Label label2;
        private TextBox txtAerolineaB;
        private Label label3;
        private TextBox txtAerolineaA;
        private Label label1;
        private TextBox txtIntencionMuelle;
        private Label lblCarga;
        private TextBox txtMediaCarga;
        private Label label5;
        private Panel pnSolucion;
    }
}