﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_4_SIM_Aeropuerto.Entidades;
using static System.Windows.Forms.DataFormats;

namespace TP_4_SIM_Aeropuerto.Interfaces
{
    public partial class SimulacionControl : UserControl
    {
        private FilaSimulacion[] simulacion;
        Color headerColor = Color.FromArgb(0, 51, 102);
        public SimulacionControl(FilaSimulacion[] f)
        {
            this.simulacion = f;

            InitializeComponent();
            CargarSimulacion();
        }
        private void CargarSimulacion()
        {
            //programar para cargar la simulacion en un dgv
            //usar el metodo ListaString() de FilaSimulacion() para cargarlas
            this.dataGridView1.Columns.Add("Evento", "Evento");
            this.dataGridView1.Columns.Add("Reloj", "Reloj");

            this.dataGridView1.Columns.Add("RND_LlegadaAvion", "RND");
            this.dataGridView1.Columns.Add("tiempo_entre_aviones", "Tiempo Entre Aviones");
            this.dataGridView1.Columns.Add("proxima_llegada", "Proxima Llegada");

            this.dataGridView1.Columns.Add("RND_Aterrizaje", "RND");
            this.dataGridView1.Columns.Add("tiempo_aterrizaje", "Tiempo Aterrizaje");
            this.dataGridView1.Columns.Add("fin_aterrizaje", "Fin Aterrizaje");
            this.dataGridView1.Columns.Add("rnd_intencion", "RND Intencion");
            this.dataGridView1.Columns.Add("intencion", "Intencion");

            this.dataGridView1.Columns.Add("RND_finOperaciones", "RND");
            this.dataGridView1.Columns.Add("tiempo_operaciones", "Tiempo");

            this.dataGridView1.Columns.Add("estado_1", "Estado");
            this.dataGridView1.Columns.Add("hora_fin_1", "Hora Fin");

            this.dataGridView1.Columns.Add("estado_2", "Estado");
            this.dataGridView1.Columns.Add("hora_fin_2", "Hora Fin");

            this.dataGridView1.Columns.Add("estado_3", "Estado");
            this.dataGridView1.Columns.Add("hora_fin_3", "Hora Fin");

            this.dataGridView1.Columns.Add("estado_4", "Estado");
            this.dataGridView1.Columns.Add("hora_fin_4", "Hora Fin");

            this.dataGridView1.Columns.Add("estado_5", "Estado");
            this.dataGridView1.Columns.Add("hora_fin_5", "Hora Fin");

            this.dataGridView1.Columns.Add("RND_LlegadaAvion_Aerolinea", "RND");
            this.dataGridView1.Columns.Add("tiempo_entre_aviones_aerolinea", "Tiempo Entre Llegadas");
            this.dataGridView1.Columns.Add("proxima_llegada", "Proxima Llegada");

            this.dataGridView1.Columns.Add("RND_fin_carga", "RND");
            this.dataGridView1.Columns.Add("tiempo_carga", "Tiempo Carga");
            this.dataGridView1.Columns.Add("fin_carga", "Fin Carga");

            this.dataGridView1.Columns.Add("estado_carga", "Estado");
            this.dataGridView1.Columns.Add("cola_carga", "Cola Carga");

            this.dataGridView1.Columns.Add("estado_pista", "Estado Pista");
            this.dataGridView1.Columns.Add("cola_pista", "Cola Pista");
            this.dataGridView1.Columns.Add("cola_pista_prioritaria", "Cola Pista Prioritaria");

            this.dataGridView1.Columns.Add("Cant_avion_gratis", "Cant aviones aterrizados gratis");
            this.dataGridView1.Columns.Add("Cant_avion_cargados", "Cant aviones que cargaron");
            this.dataGridView1.Columns.Add("Acum_tiempo_espera", "Acum tiempo espera de aterrizaje");
            this.dataGridView1.Columns.Add("Cant_avion_aterrizados", "Total aviones aterrizados");
            this.dataGridView1.Columns.Add("Cant_avion_descuento", "Cant aterrizados aviones con descuento ");
            int i = 1;
            foreach (Avion a in simulacion[simulacion.Length - 1].aviones)
            {
                this.dataGridView1.Columns.Add("estado_avion" + i.ToString(), "Estado");
                this.dataGridView1.Columns.Add("hora_llegada" + i.ToString(), "Hora Llegada");
            }
            i = 0;
            foreach (AvionAerolinea a in simulacion[simulacion.Length - 1].avionesAerolinea)
            {
                this.dataGridView1.Columns.Add("estado_avion" + i.ToString(), "Estado");
                this.dataGridView1.Columns.Add("hora_llegada" + i.ToString(), "Hora Llegada");
            }


            //this.dataGridView1.Columns.Add("estado_avion_2", "Estado");
            //this.dataGridView1.Columns.Add("hora_llegada_2", "Hora Llegada");

            //this.dataGridView1.Columns.Add("estado_avion_3", "Estado");
            //this.dataGridView1.Columns.Add("hora_llegada_3", "Hora Llegada");

            //this.dataGridView1.Columns.Add("estado_avion_4", "Estado");
            //this.dataGridView1.Columns.Add("hora_llegada_4", "Hora Llegada");

            //this.dataGridView1.Columns.Add("estado_avion_5", "Estado");
            //this.dataGridView1.Columns.Add("hora_llegada_5", "Hora Llegada");

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = this.dataGridView1.ColumnHeadersHeight * 3 + 20;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            this.dataGridView1.CellPainting += new DataGridViewCellPaintingEventHandler(dataGridView1_CellPainting);
            this.dataGridView1.Paint += new PaintEventHandler(dataGridView1_Paint);
            this.dataGridView1.Scroll += new ScrollEventHandler(dataGridView1_Scroll);
            this.dataGridView1.ColumnWidthChanged += new DataGridViewColumnEventHandler(dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Dock = DockStyle.Fill;


            foreach (FilaSimulacion f in simulacion)
            {
                this.dataGridView1.Rows.Add(f.ListaString());
            }

        }

        private void SimulacionControl_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle rtHeader = this.dataGridView1.DisplayRectangle;
            rtHeader.Height = this.dataGridView1.ColumnHeadersHeight / 2;
            this.dataGridView1.Invalidate(rtHeader);
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {



            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                if (this.dataGridView1.Columns[i].Index == 2)
                {
                    CustomizeCell(i, e, "Llegada Avion", 3);
                }
                if (this.dataGridView1.Columns[i].Index == 5)
                {
                    CustomizeCell(i, e, "Fin Aterrizaje", 5);
                }
                if (this.dataGridView1.Columns[i].Index == 10)
                {
                    CustomizeCell(i, e, "Fin Operaciones", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 12)
                {
                    CustomizeCell(i, e, "Muelle 1", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 14)
                {
                    CustomizeCell(i, e, "Muelle 2", 2);
                }


                if (this.dataGridView1.Columns[i].Index == 16)
                {
                    CustomizeCell(i, e, "Muelle 3", 2);
                }


                if (this.dataGridView1.Columns[i].Index == 18)
                {
                    CustomizeCell(i, e, "Muelle 4", 2);
                }


                if (this.dataGridView1.Columns[i].Index == 20)
                {
                    CustomizeCell(i, e, "Muelle 5", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 22)
                {
                    CustomizeCell(i, e, "Llegada Avion Aerolinea", 3);
                }


                if (this.dataGridView1.Columns[i].Index == 25)
                {
                    CustomizeCell(i, e, "Fin Carga", 3);
                }

                if (this.dataGridView1.Columns[i].Index == 28)
                {
                    CustomizeCell(i, e, "Puesto de Carga", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 30)
                {
                    CustomizeCell(i, e, "Pista", 3);
                }

                if (this.dataGridView1.Columns[i].Index == 38)
                {
                    CustomizeCell(i, e, "Avion 1", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 40)
                {
                    CustomizeCell(i, e, "Avion 2", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 42)
                {
                    CustomizeCell(i, e, "Avion 3", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 44)
                {
                    CustomizeCell(i, e, "Avion 4", 2);
                }

                if (this.dataGridView1.Columns[i].Index == 46)
                {
                    CustomizeCell(i, e, "Avion 5", 2);
                }
            }

            int c = 0;
            foreach (Avion a in simulacion[simulacion.Length - 1].aviones)
            {
                CustomizeCell(38 + c * 2, e, "Avion" + (c + 1).ToString(), 2);
                c++;
            }
            int constante = 1;
            foreach (AvionAerolinea av in simulacion[simulacion.Length - 1].avionesAerolinea)
            {
                CustomizeCell(38 + c * 2, e, " Avion A" + (constante).ToString(), 2);
                c++;
                constante++;
            }
        }

        private void CustomizeCell(int index, PaintEventArgs e, string header, int cellsOverlapped)
        {
            Rectangle r1 = this.dataGridView1.GetCellDisplayRectangle(index, -1, true);

            int[] wk = new int[cellsOverlapped];
            int sum = 0;

            for (int i = 1; i < cellsOverlapped; i++)
            {
                wk[i] = this.dataGridView1.GetCellDisplayRectangle(index + i, -1, true).Width;
                sum += wk[i];
            }

            r1.X += 1;
            r1.Y += 1;
            r1.Width = r1.Width + sum - 2;
            r1.Height = r1.Height / 3 - 2;
            e.Graphics.FillRectangle(new SolidBrush(headerColor), r1);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(header,
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font,
            new SolidBrush(this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor),
            r1,
            format);

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                Rectangle r2 = e.CellBounds;
                r2.Y += e.CellBounds.Height / 2;
                r2.Height = e.CellBounds.Height / 2;
                e.PaintBackground(r2, true);
                e.PaintContent(r2);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
