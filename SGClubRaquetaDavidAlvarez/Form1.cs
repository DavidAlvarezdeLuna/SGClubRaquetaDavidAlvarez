using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDavidAlvarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void strip_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strip_pistas_Click(object sender, EventArgs e)
        {
            Form_pistas p = new Form_pistas();
            p.ShowDialog();
        }


        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void strip_reservas_Click(object sender, EventArgs e)
        {
            //FormReservas r = new FormReservas();
            //r.ShowDialog();

            if (this.MdiChildren.Length > 0)
            { //si tiene al menos un hijo
                if (this.MdiChildren[0].Name != "FormReservas")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar el formulario?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //ventana que prgunta si quieres cerrar
                    if (rs == DialogResult.Yes)
                    {
                        MdiChildren[0].Close();
                        FormReservas r = new FormReservas();
                        r.MdiParent = this;
                        r.Dock = DockStyle.Fill;
                        r.Show();
                    }
                }
            }
            else //si no tiene hijos
            {
                FormReservas t = new FormReservas();
                t.MdiParent = this; //form1 es su padre
                t.Dock = DockStyle.Fill; //que el hijo que vas a abrir llene todo el espacio que sobre en la ventana
                t.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void strip_socios_Click(object sender, EventArgs e)
        {
            FormSocios s = new FormSocios();
            s.ShowDialog();
        }
    }
}

