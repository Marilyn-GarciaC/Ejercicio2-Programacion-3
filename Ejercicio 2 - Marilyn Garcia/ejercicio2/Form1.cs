using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        string[] estudiante = new string[10];
        string[] estudiante_edad = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)   //puse uno para que se agregara 1 por 1 
            {
                estudiante[i] = textBoxNombre.Text;
                estudiante_edad[i] = textBoxEdad.Text;

            }

            for (int i = 0; i < 1; i++)
            {
                listBox1.Items.Add(estudiante[i] + " " + "su edad es: " + estudiante_edad[i]);

            }




        }
    }
}
