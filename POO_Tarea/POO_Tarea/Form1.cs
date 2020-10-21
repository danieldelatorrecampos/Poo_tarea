using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsola_Click(object sender, EventArgs e)
        {
            ConsolaDeVideojuegos P;
            P = new ConsolaDeVideojuegos();
            P.precio = s12500;
            MessageBox.Show(P.ToString());
        }

        private void btnXbox_Click(object sender, EventArgs e)
        {
            Xbox m;
            m = new Xbox();
            m.Modelo = "Xboxones";
            m.Precio = 12500;
            MessageBox.Show(m.ToString());
        }
    }
}
