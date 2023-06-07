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
            btnSimulacion = new Button();
            panel1 = new Panel();
            btnConclusion = new Button();
            pnResultados = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSimulacion
            // 
            btnSimulacion.Cursor = Cursors.Hand;
            btnSimulacion.Dock = DockStyle.Left;
            btnSimulacion.FlatStyle = FlatStyle.Flat;
            btnSimulacion.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimulacion.ForeColor = Color.FromArgb(230, 230, 240);
            btnSimulacion.Location = new Point(0, 0);
            btnSimulacion.Margin = new Padding(3, 4, 3, 4);
            btnSimulacion.Name = "btnSimulacion";
            btnSimulacion.Size = new Size(576, 133);
            btnSimulacion.TabIndex = 0;
            btnSimulacion.Text = "Simulacion";
            btnSimulacion.UseVisualStyleBackColor = true;
            btnSimulacion.Click += btnSimulacion_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConclusion);
            panel1.Controls.Add(btnSimulacion);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1125, 133);
            panel1.TabIndex = 1;
            // 
            // btnConclusion
            // 
            btnConclusion.Cursor = Cursors.Hand;
            btnConclusion.Dock = DockStyle.Fill;
            btnConclusion.FlatStyle = FlatStyle.Flat;
            btnConclusion.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConclusion.ForeColor = Color.FromArgb(230, 230, 240);
            btnConclusion.Location = new Point(576, 0);
            btnConclusion.Margin = new Padding(3, 4, 3, 4);
            btnConclusion.Name = "btnConclusion";
            btnConclusion.Size = new Size(549, 133);
            btnConclusion.TabIndex = 1;
            btnConclusion.Text = "Conclusion";
            btnConclusion.UseVisualStyleBackColor = true;
            btnConclusion.Click += btnConclusion_Click;
            // 
            // pnResultados
            // 
            pnResultados.Dock = DockStyle.Fill;
            pnResultados.Location = new Point(0, 133);
            pnResultados.Margin = new Padding(3, 4, 3, 4);
            pnResultados.Name = "pnResultados";
            pnResultados.Size = new Size(1125, 347);
            pnResultados.TabIndex = 2;
            pnResultados.Paint += pnResultados_Paint;
            // 
            // ResultadosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 30, 40);
            Controls.Add(pnResultados);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResultadosControl";
            Size = new Size(1125, 480);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimulacion;
        private Panel panel1;
        private Button btnConclusion;
        private Panel pnResultados;
    }
}
