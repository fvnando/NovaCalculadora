using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora1
{
    public partial class Form1 : Form
    {
        String op, num2="";
        Double num = 0, num1=0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (txtValor.Text == "0")
            {
                txtValor.Text = "";
                txtValor.Text = txtValor.Text + bt.Text;
            }
            else
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtValor.Text = "0";
        }

        private void Bt_virgula(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            { 
                num1 =num1+ Convert.ToDouble(txtValor.Text);
                num2 = Convert.ToString(num);
                txtValor.Text = Convert.ToString(num2);         
                op = "+";
            }
            else {
                //txtValor.Text = txtValor.Text + bt_soma.Text;
                num1 = Convert.ToDouble(txtValor.Text);
                txtValor.Text = Convert.ToString(num1);
                txtValor.Text = "";
                op = "+";
                validar = true;
            }
        }
    }
}
