using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ02
{
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Multiplicação m;
            m = new Multiplicação();
            m.setAresta(int.Parse(txtLado1.Text));
        
            m.calcularArea();

            lblresultado.Text = m.getArea().ToString();
     
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
