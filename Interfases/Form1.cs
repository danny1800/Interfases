using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computadora 
        {
            void CompuEscritorio();
            void CompuPortatil();
        }

        interface Modelo 
        {
            void Modelo();
        }

        interface tienda 
        {
            void tienda();
        }

        class ComputadoraASUS : Computadora, Modelo , tienda
        {
            //atributos
            public string nombre {  get; set; }
            public double precio { get; set; }
            public string modelo { get; set; }
            public string Tienda { get; set; }
            public void CompuEscritorio()
            {
                nombre = "compu1";
                precio = 13000;
            }

            public void CompuPortatil()
            {
                nombre = "laptop";
                precio = 10000;
            }

            public void Modelo()
            {
                modelo = "Rod strix";
            }

            public void tienda()
            {
                Tienda = "sucursal LibresPool";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComputadoraASUS computadora = new ComputadoraASUS();
            ComputadoraASUS CompuPortatil = new ComputadoraASUS();
            computadora.CompuEscritorio();
            CompuPortatil.CompuPortatil();
            computadora.Modelo();
            CompuPortatil.tienda();
            string texto = "el nombre de la computadora es: " + computadora.nombre + Environment.NewLine;
            texto += "el costo es: " + computadora.precio + Environment.NewLine;
            texto += "La laptop es: " + CompuPortatil.nombre + Environment.NewLine;
            texto += "el costo es: " + CompuPortatil.precio + Environment.NewLine;
            texto += "el modelo es: " + CompuPortatil.modelo + Environment.NewLine;
            texto += "la tienda es: " + CompuPortatil.Tienda + Environment.NewLine;
            textBox1.Text += texto;
        }
    }
}
