﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meuPrimeiroForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 / numero2}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMultiplicacao1(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 * numero2}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1, numero2;
            numero1 = int.Parse(txtNumero1.Text);
            numero2 = int.Parse(txtNumero2.Text);
            MessageBox.Show($"{numero1 - numero2}");
        }

    }
}
