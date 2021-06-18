using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpaiImplementacion.IU
{
    public partial class Venta_Entradas : Form
    {
        public Venta_Entradas()
        {
            InitializeComponent();
        }

        private void Btn_Salir_1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void opcionRegistrarVentaDeEntradas_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
