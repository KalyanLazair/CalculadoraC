using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraC
{
    public partial class Form1 : Form
    {
        //Declaramos las variables de instancia. Guardamos el primer número.
        double operando1 = 0;
        //En este String guardamos la operación pulsada (+,-,*,/)
        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //Casteamos el object genérico sender a un objeto Button para que lo reconozca como botón.
            Button boton = (Button)sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else {
                label1.Text = label1.Text + boton.Text;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);  //Lo convertimos a double.
            label1.Text = "0"; //Reseteamos el valor en el label1 para poder escribir el segundo número.
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //No casteamos porque no tenemos que leer etiquetas ni nada. A este botón sólo se llega por el igual.
            Double operando2 = Convert.ToDouble(label1.Text);
            Double resultado = 0;
            if (operacion == "+") {
                resultado = operando1 + operando2;
            } else if (operacion == "-") {
                resultado = operando1 - operando2;
            }

            label1.Text = Convert.ToString(resultado);
        }
    }
}
