namespace TP_4_SIM_Aeropuerto.Interfaces
{
    partial class ResultadosControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConclusion = new System.Windows.Forms.Button();
            this.btnRungeKuta = new System.Windows.Forms.Button();
            this.pnResultados = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSimulacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimulacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSimulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSimulacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnSimulacion.Location = new System.Drawing.Point(0, 0);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(328, 100);
            this.btnSimulacion.TabIndex = 0;
            this.btnSimulacion.Text = "Simulacion";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConclusion);
            this.panel1.Controls.Add(this.btnRungeKuta);
            this.panel1.Controls.Add(this.btnSimulacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnConclusion
            // 
            this.btnConclusion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConclusion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConclusion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConclusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConclusion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConclusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnConclusion.Location = new System.Drawing.Point(656, 0);
            this.btnConclusion.Name = "btnConclusion";
            this.btnConclusion.Size = new System.Drawing.Size(328, 100);
            this.btnConclusion.TabIndex = 1;
            this.btnConclusion.Text = "Conclusion";
            this.btnConclusion.UseVisualStyleBackColor = true;
            this.btnConclusion.Click += new System.EventHandler(this.btnConclusion_Click);
            // 
            // btnRungeKuta
            // 
            this.btnRungeKuta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRungeKuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRungeKuta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRungeKuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRungeKuta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRungeKuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.btnRungeKuta.Location = new System.Drawing.Point(328, 0);
            this.btnRungeKuta.Name = "btnRungeKuta";
            this.btnRungeKuta.Size = new System.Drawing.Size(328, 100);
            this.btnRungeKuta.TabIndex = 1;
            this.btnRungeKuta.Text = "Tablas Runge Kuta";
            this.btnRungeKuta.UseVisualStyleBackColor = true;
            this.btnRungeKuta.Click += new System.EventHandler(this.btnRungeKuta_Click);
            // 
            // pnResultados
            // 
            this.pnResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResultados.Location = new System.Drawing.Point(0, 100);
            this.pnResultados.Name = "pnResultados";
            this.pnResultados.Size = new System.Drawing.Size(984, 260);
            this.pnResultados.TabIndex = 2;
            // 
            // ResultadosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.pnResultados);
            this.Controls.Add(this.panel1);
            this.Name = "ResultadosControl";
            this.Size = new System.Drawing.Size(984, 360);
            this.SizeChanged += new System.EventHandler(this.ResultadosControl_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSimulacion;
        private Panel panel1;
        private Button btnConclusion;
        private Panel pnResultados;
        private Button btnRungeKuta;
    }
}
