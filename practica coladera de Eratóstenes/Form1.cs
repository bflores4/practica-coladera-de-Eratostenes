using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_coladera_de_Eratóstenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Arreglo arreglo;

        private void btnObtener_Click(object sender, EventArgs e)
        {
            txtNumerosPrimos.Text = "";
            txtNumerosPrimos.Text =Arreglo.coladera(Convert.ToInt16(txtNum.Text));
        }
    }
}
