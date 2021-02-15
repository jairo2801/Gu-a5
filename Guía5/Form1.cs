using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double salario = Double.Parse(txt2.Text);
                double descuento, total;
                String nombre = txt1.Text;

                if (rbtn1gerente.Checked == true)
                {
                    descuento = salario * 0.20;
                    total = salario - descuento;

                    MessageBox.Show("Hola " + nombre + " eres un Gerente y tu salario es de $" + salario + ", al cual se le descuentan $" + descuento + " por lo que su sueldo liquido es de $" + total);
                }
                if (rbtn2subgerente.Checked == true)
                {
                    descuento = salario * 0.15;
                    total = salario - descuento;

                    MessageBox.Show("Hola " + nombre + " eres un SubGerente y tu salario es de $" + salario + ", al cual se le descuentan $" + descuento + " por lo que su sueldo liquido es de $" + total);
                }
                if (rbtn3secretaria.Checked == true)
                {
                    descuento = salario * 0.05;
                    total = salario - descuento;

                    MessageBox.Show("Hola " + nombre + " eres una Secretaria y tu salario es de $" + salario + ", al cual se le descuentan $" + descuento + " por lo que su sueldo liquido es de $" + total);
                }
                else if (rbtn1gerente.Checked == false && rbtn2subgerente.Checked == false && rbtn3secretaria.Checked == false)
                {
                    MessageBox.Show("Usted no ha seleccionado ninguna de las opciones");
                }

            }
            catch (Exception ex)
            {
                String Message = ex.Message;
            }
        }
    }
}
