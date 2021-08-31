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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hcemos invisibles los controladores que nos daran los resultados
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtMdescuento.Visible = false;
            txtSneto.Visible = false;
            button1.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaramos variables 
            double salneto, n1, resta;
            
            if (radioButton1.Checked == true)
            {
                //Convertimos el valor del textbox para operarlo
                n1 = Convert.ToDouble(txtSbruto.Text);
                //hacemos la operacion
                salneto = n1 * 0.2;
                resta = n1 - salneto;
                //habilitamos los controladores de los resultados
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                txtMdescuento.Visible = true;
                txtSneto.Visible = true;
                button1.Visible = true;
                //Mostramos los resultados en los controladores
                label7.Text = "El trabajador" + txtNombre.Text + " " + txtApellido.Text;
                label8.Text = "Con cargo de de Gerente";
                txtMdescuento.Text = "Descuento 20%";
                txtSneto.Text = Convert.ToString(resta);

            }
            //repetimos el proceso del primer if
             if (radioButton2.Checked == true)
            {
                n1 = Convert.ToDouble(txtSbruto.Text);
                salneto = n1 * 0.15;
                resta = n1 - salneto;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                txtMdescuento.Visible = true;
                txtSneto.Visible = true;
                button1.Visible = true;
                label7.Text = "El trabajador" + txtNombre.Text + " " + txtApellido.Text;
                label8.Text = "Con cargo de de SubGerente";
                txtMdescuento.Text = "Descuento 15%";
                txtSneto.Text = Convert.ToString(resta);

            }
            //repetimos el proceso del primer if
            if (radioButton3.Checked == true)
            {
                n1 = Convert.ToDouble(txtSbruto.Text);
                salneto = n1 * 0.05;
                resta = n1 - salneto;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                txtMdescuento.Visible = true;
                txtSneto.Visible = true;
                button1.Visible = true;
                label7.Text = "El trabajador: " + txtNombre.Text + " " + txtApellido.Text;
                label8.Text = "Con cargo de de Secretaria";
                txtMdescuento.Text = "Descuento 5%";
                txtSneto.Text = Convert.ToString(resta);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //borramos todo lo del formulario y reiniciamos desde cero
            label7.Text = "";
            label8.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtSbruto.Clear();
            txtMdescuento.Clear();
            txtSneto.Clear();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            txtMdescuento.Visible = false;
            txtSneto.Visible = false;
            button1.Visible = false;
        }

        //Mandamos a llamar los otros programas del proyecto con el menu
        private void formularioConversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario2 = new Form2();
            formulario2.Show();
        }

        private void formularioDecuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario1 = new Form1();
            formulario1.Show();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
