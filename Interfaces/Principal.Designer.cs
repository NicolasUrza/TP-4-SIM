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
            this.pnParametros = new System.Windows.Forms.Panel();
            this.txtMediaCarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAerolineaB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAerolineaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntencionMuelle = new System.Windows.Forms.TextBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.btnGenerarSimulacion = new System.Windows.Forms.Button();
            this.txtIntencionCarga = new System.Windows.Forms.TextBox();
            this.lblIntención = new System.Windows.Forms.Label();
            this.txtMediaMuelle = new System.Windows.Forms.TextBox();
            this.lblMuelle = new System.Windows.Forms.Label();
            this.txtAterrizaje = new System.Windows.Forms.TextBox();
            this.lblAterrizaje = new System.Windows.Forms.Label();
            this.txtLlegadaAvion = new System.Windows.Forms.TextBox();
            this.lblLLegadaAviones = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblMostrarDesde = new System.Windows.Forms.Label();
            this.txtCantIteraciones = new System.Windows.Forms.TextBox();
            this.lblCantIteraciones = new System.Windows.Forms.Label();
            this.pnSolucion = new System.Windows.Forms.Panel();
            this.pnParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnParametros
            // 
            this.pnParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnParametros.Controls.Add(this.txtMediaCarga);
            this.pnParametros.Controls.Add(this.label5);
            this.pnParametros.Controls.Add(this.label4);
            this.pnParametros.Controls.Add(this.label2);
            this.pnParametros.Controls.Add(this.txtAerolineaB);
            this.pnParametros.Controls.Add(this.label3);
            this.pnParametros.Controls.Add(this.txtAerolineaA);
            this.pnParametros.Controls.Add(this.label1);
            this.pnParametros.Controls.Add(this.txtIntencionMuelle);
            this.pnParametros.Controls.Add(this.lblCarga);
            this.pnParametros.Controls.Add(this.btnGenerarSimulacion);
            this.pnParametros.Controls.Add(this.txtIntencionCarga);
            this.pnParametros.Controls.Add(this.lblIntención);
            this.pnParametros.Controls.Add(this.txtMediaMuelle);
            this.pnParametros.Controls.Add(this.lblMuelle);
            this.pnParametros.Controls.Add(this.txtAterrizaje);
            this.pnParametros.Controls.Add(this.lblAterrizaje);
            this.pnParametros.Controls.Add(this.txtLlegadaAvion);
            this.pnParametros.Controls.Add(this.lblLLegadaAviones);
            this.pnParametros.Controls.Add(this.txtDesde);
            this.pnParametros.Controls.Add(this.lblMostrarDesde);
            this.pnParametros.Controls.Add(this.txtCantIteraciones);
            this.pnParametros.Controls.Add(this.lblCantIteraciones);
            this.pnParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnParametros.Location = new System.Drawing.Point(0, 0);
            this.pnParametros.Name = "pnParametros";
            this.pnParametros.Size = new System.Drawing.Size(984, 201);
            this.pnParametros.TabIndex = 0;
            // 
            // txtMediaCarga
            // 
            this.txtMediaCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtMediaCarga.Location = new System.Drawing.Point(344, 111);
            this.txtMediaCarga.Name = "txtMediaCarga";
            this.txtMediaCarga.Size = new System.Drawing.Size(100, 23);
            this.txtMediaCarga.TabIndex = 24;
            this.txtMediaCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediaCarga_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label5.Location = new System.Drawing.Point(219, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Media Carga: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Llegada Avion Aerolinea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(345, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "B:";
            // 
            // txtAerolineaB
            // 
            this.txtAerolineaB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtAerolineaB.Location = new System.Drawing.Point(375, 166);
            this.txtAerolineaB.Name = "txtAerolineaB";
            this.txtAerolineaB.Size = new System.Drawing.Size(60, 23);
            this.txtAerolineaB.TabIndex = 20;
            this.txtAerolineaB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAerolineaB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(215, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "A:";
            // 
            // txtAerolineaA
            // 
            this.txtAerolineaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtAerolineaA.Location = new System.Drawing.Point(245, 166);
            this.txtAerolineaA.Name = "txtAerolineaA";
            this.txtAerolineaA.Size = new System.Drawing.Size(60, 23);
            this.txtAerolineaA.TabIndex = 18;
            this.txtAerolineaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAerolineaA_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(311, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Muelle:";
            // 
            // txtIntencionMuelle
            // 
            this.txtIntencionMuelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtIntencionMuelle.Location = new System.Drawing.Point(375, 137);
            this.txtIntencionMuelle.Name = "txtIntencionMuelle";
            this.txtIntencionMuelle.Size = new System.Drawing.Size(60, 23);
            this.txtIntencionMuelle.TabIndex = 16;
            this.txtIntencionMuelle.TextChanged += new System.EventHandler(this.txtIntencionMuelle_TextChanged);
            this.txtIntencionMuelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntencionMuelle_KeyPress);
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblCarga.Location = new System.Drawing.Point(181, 137);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(58, 17);
            this.lblCarga.TabIndex = 15;
            this.lblCarga.Text = "Carga:";
            // 
            // btnGenerarSimulacion
            // 
            this.btnGenerarSimulacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarSimulacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarSimulacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnGenerarSimulacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnGenerarSimulacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.btnGenerarSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarSimulacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarSimulacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnGenerarSimulacion.Location = new System.Drawing.Point(776, 39);
            this.btnGenerarSimulacion.Name = "btnGenerarSimulacion";
            this.btnGenerarSimulacion.Size = new System.Drawing.Size(164, 131);
            this.btnGenerarSimulacion.TabIndex = 14;
            this.btnGenerarSimulacion.Text = "Generar";
            this.btnGenerarSimulacion.UseVisualStyleBackColor = true;
            this.btnGenerarSimulacion.Click += new System.EventHandler(this.btnGenerarSimulacion_Click_1);
            // 
            // txtIntencionCarga
            // 
            this.txtIntencionCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtIntencionCarga.Location = new System.Drawing.Point(245, 138);
            this.txtIntencionCarga.Name = "txtIntencionCarga";
            this.txtIntencionCarga.Size = new System.Drawing.Size(60, 23);
            this.txtIntencionCarga.TabIndex = 11;
            this.txtIntencionCarga.TextChanged += new System.EventHandler(this.txtIntencionCarga_TextChanged);
            this.txtIntencionCarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntencionCarga_KeyPress);
            // 
            // lblIntención
            // 
            this.lblIntención.AutoSize = true;
            this.lblIntención.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntención.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblIntención.Location = new System.Drawing.Point(99, 138);
            this.lblIntención.Name = "lblIntención";
            this.lblIntención.Size = new System.Drawing.Size(76, 17);
            this.lblIntención.TabIndex = 10;
            this.lblIntención.Text = "Intención";
            // 
            // txtMediaMuelle
            // 
            this.txtMediaMuelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtMediaMuelle.Location = new System.Drawing.Point(345, 82);
            this.txtMediaMuelle.Name = "txtMediaMuelle";
            this.txtMediaMuelle.Size = new System.Drawing.Size(100, 23);
            this.txtMediaMuelle.TabIndex = 9;
            this.txtMediaMuelle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediaMuelle_KeyPress);
            // 
            // lblMuelle
            // 
            this.lblMuelle.AutoSize = true;
            this.lblMuelle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMuelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblMuelle.Location = new System.Drawing.Point(219, 80);
            this.lblMuelle.Name = "lblMuelle";
            this.lblMuelle.Size = new System.Drawing.Size(111, 17);
            this.lblMuelle.TabIndex = 8;
            this.lblMuelle.Text = "Media Muelle: ";
            // 
            // txtAterrizaje
            // 
            this.txtAterrizaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtAterrizaje.Location = new System.Drawing.Point(345, 52);
            this.txtAterrizaje.Name = "txtAterrizaje";
            this.txtAterrizaje.Size = new System.Drawing.Size(100, 23);
            this.txtAterrizaje.TabIndex = 7;
            this.txtAterrizaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAterrizaje_KeyPress);
            // 
            // lblAterrizaje
            // 
            this.lblAterrizaje.AutoSize = true;
            this.lblAterrizaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAterrizaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblAterrizaje.Location = new System.Drawing.Point(197, 51);
            this.lblAterrizaje.Name = "lblAterrizaje";
            this.lblAterrizaje.Size = new System.Drawing.Size(133, 17);
            this.lblAterrizaje.TabIndex = 6;
            this.lblAterrizaje.Text = "Media Aterrizaje:";
            // 
            // txtLlegadaAvion
            // 
            this.txtLlegadaAvion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtLlegadaAvion.Location = new System.Drawing.Point(345, 20);
            this.txtLlegadaAvion.Name = "txtLlegadaAvion";
            this.txtLlegadaAvion.Size = new System.Drawing.Size(100, 23);
            this.txtLlegadaAvion.TabIndex = 5;
            this.txtLlegadaAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLlegadaAvion_KeyPress);
            // 
            // lblLLegadaAviones
            // 
            this.lblLLegadaAviones.AutoSize = true;
            this.lblLLegadaAviones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLLegadaAviones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblLLegadaAviones.Location = new System.Drawing.Point(150, 23);
            this.lblLLegadaAviones.Name = "lblLLegadaAviones";
            this.lblLLegadaAviones.Size = new System.Drawing.Size(180, 17);
            this.lblLLegadaAviones.TabIndex = 4;
            this.lblLLegadaAviones.Text = "Media Llegada Aviones:";
            // 
            // txtDesde
            // 
            this.txtDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtDesde.Location = new System.Drawing.Point(648, 50);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 23);
            this.txtDesde.TabIndex = 3;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // lblMostrarDesde
            // 
            this.lblMostrarDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMostrarDesde.AutoSize = true;
            this.lblMostrarDesde.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblMostrarDesde.Location = new System.Drawing.Point(485, 50);
            this.lblMostrarDesde.Name = "lblMostrarDesde";
            this.lblMostrarDesde.Size = new System.Drawing.Size(124, 17);
            this.lblMostrarDesde.TabIndex = 2;
            this.lblMostrarDesde.Text = "Mostrar Desde: ";
            // 
            // txtCantIteraciones
            // 
            this.txtCantIteraciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantIteraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(217)))));
            this.txtCantIteraciones.Location = new System.Drawing.Point(648, 21);
            this.txtCantIteraciones.Name = "txtCantIteraciones";
            this.txtCantIteraciones.Size = new System.Drawing.Size(100, 23);
            this.txtCantIteraciones.TabIndex = 1;
            this.txtCantIteraciones.TextChanged += new System.EventHandler(this.txtCantIteraciones_TextChanged);
            this.txtCantIteraciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantIteraciones_KeyPress);
            // 
            // lblCantIteraciones
            // 
            this.lblCantIteraciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantIteraciones.AutoSize = true;
            this.lblCantIteraciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantIteraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.lblCantIteraciones.Location = new System.Drawing.Point(445, 21);
            this.lblCantIteraciones.Name = "lblCantIteraciones";
            this.lblCantIteraciones.Size = new System.Drawing.Size(191, 17);
            this.lblCantIteraciones.TabIndex = 0;
            this.lblCantIteraciones.Text = "Cantidad de Iteraciones: ";
            // 
            // pnSolucion
            // 
            this.pnSolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnSolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSolucion.Location = new System.Drawing.Point(0, 201);
            this.pnSolucion.Name = "pnSolucion";
            this.pnSolucion.Size = new System.Drawing.Size(984, 410);
            this.pnSolucion.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnSolucion);
            this.Controls.Add(this.pnParametros);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeropuerto";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            this.pnParametros.ResumeLayout(false);
            this.pnParametros.PerformLayout();
            this.ResumeLayout(false);

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