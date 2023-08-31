using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecursividadC_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalcularFactorialRecursivo(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalcularFactorialRecursivo(n - 1);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int factorial = CalcularFactorialRecursivo(numero);
            lblResultado.Text = $"El factorial de {numero} es {factorial}";
        }
    }
}
