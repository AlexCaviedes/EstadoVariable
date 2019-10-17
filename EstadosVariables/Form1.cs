using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosVariables
{
    public partial class Form1 : Form
    {
        private int Uno;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            Uno++;
            txtNumero.Text = Uno.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero.Text = "1";
        }
    }
}
