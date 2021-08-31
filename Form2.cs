using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario5_VE202846
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        //mandamos a llamar los otros formularios del proyecto
        private void formularioDecuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Form1();
            formulario1.Show();
        }

        private void formularioConversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

        private void formulaCuadraticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario3 = new Form3();
            formulario3.Show();
        }

        private void ejemplo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario4 = new Form4();
            formulario4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //validamos el radiobutton activo
            if (radioButton1.Checked == true)
            {
                //declaramos las variables
                double opera, n1;
                //Convertir el valor del texto para ser operable
                n1 = Convert.ToDouble(textBox1.Text);
                //hacemos la operacion correspondiente
                opera = (n1 - 32) * 5 / 9;
                //Mostramos resultados
                textBox2.Text = Convert.ToString(opera);
                label5.Text = "Conversion a fahrenheit :";
            }

            //Repetimos lo mismo del primer if
            if (radioButton2.Checked == true)
            {
                double opera, n1;
                n1 = Convert.ToDouble(textBox1.Text);
                opera = n1 * 3.281;
                textBox2.Text = Convert.ToString(opera);
                label5.Text = "Conversion a pies :";
            }
            //Repetimos lo mismo del primer if
            if (radioButton3.Checked == true)
            {
                double opera, n1;
                n1 = Convert.ToDouble(textBox1.Text);
                opera = n1 * 2.205;
                textBox2.Text = Convert.ToString(opera);
                label5.Text = "Conversion a Libras :";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
