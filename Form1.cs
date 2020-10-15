using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenContadores
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next(1, 100);
            textBox1.Text = num.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
