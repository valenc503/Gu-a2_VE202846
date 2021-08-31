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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaramos variables
            double a, b, c, calcu1, calcu2, divx1, divx2, dentroraiz;
            //convertimos los valores de los textbox para ser operables
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            //Hacemos las operaciones para obtener la formula cuadratica
            dentroraiz = (b * b) - 4 * a * c;
            calcu1 = -b + Math.Sqrt(dentroraiz);
            calcu2 = -b - Math.Sqrt(dentroraiz);
            divx1 = calcu1 / (2 * a);
            divx2 = calcu2 / (2 * a);
            //Mostramos los resultados 
            textBox4.Text = Convert.ToString(divx1);
            textBox5.Text = Convert.ToString(divx2);
        }

        //Mandamos a llamar los otros formularios
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
    }
}
