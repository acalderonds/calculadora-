using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class Calculadora
    {

        public static void main(String[] args)
        {
           // Calculator A = new Calculator();

           // System.out.println(A.multiplicar(5, 2));
        }

    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x, y;

        private void btnresta_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x - y);
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            double resultado = x * y;
            txtresultado.Text = Convert.ToString(resultado);
            //txtresultado.Text = string.Format("{0:f2", x * y);
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x / y);

        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            double resultado = Math.Pow(x, y);
            txtresultado.Text = string.Format("{0:f2}", resultado);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtnum1.Text);
            double resultado = Math.Sqrt(x); 
            txtresultado.Text = string.Format("{0:f2}", txtresultado);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado.Text = "";
        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
           // txtresultado.Text  = string.Format(txtnum1,txtnum2);
        }

        private void buttonsumaClick(object sender, EventArgs e)
        {
            
            x = Convert.ToDouble(txtnum1.Text);
            y = Convert.ToDouble(txtnum2.Text);
            txtresultado.Text = string.Format("{0:f2}", x + y);
        }
    }
}


