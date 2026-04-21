using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroSGF
{
    public partial class frmPricipal : Form
    {
        public frmPricipal()
        {
            InitializeComponent();
        }

        private void tabConsultar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            // Definimos el color y el grosor de la línea
            Pen pen = new Pen(Color.Black, 2);
            // Dibujamos el rectángulo (ajustando un poco el margen superior por el texto)
            e.Graphics.DrawRectangle(pen, 0, 10, box.Width - 1, box.Height - 11);
        }

        private void gpbDatosChofer_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            // Definimos el color y el grosor de la línea
            Pen pen = new Pen(Color.Black, 2);
            // Dibujamos el rectángulo (ajustando un poco el margen superior por el texto)
            e.Graphics.DrawRectangle(pen, 0, 10, box.Width - 1, box.Height - 11);
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            // Definimos el color y el grosor de la línea
            Pen pen = new Pen(Color.Black, 2);
            // Dibujamos el rectángulo (ajustando un poco el margen superior por el texto)
            e.Graphics.DrawRectangle(pen, 0, 10, box.Width - 1, box.Height - 11);
        }
    }
}
