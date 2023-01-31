using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distancia_en_plano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo Operacion = new Calculo();
            double resultado = Operacion.operacion(double.Parse(txtX2.Text), double.Parse(txtX1.Text), double.Parse(txtY1.Text), double.Parse(txtY2.Text));
            txtResultado.Text = resultado.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtResultado.Clear();
        }
    }
}
