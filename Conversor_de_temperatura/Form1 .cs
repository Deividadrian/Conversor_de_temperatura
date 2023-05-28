using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double TCel, TKel, TFah;

                TCel = double.Parse(textBox1.Text);

                TKel = TCel + 273.15;
                TFah = ((TCel * 9/5)+32);

                label3.Text = TKel.ToString();
                label5.Text = TFah.ToString();

            }

            catch (Exception)
            {
                MessageBox.Show("Esta não é uma entrada válida",
                    "*  ATENÇÃO, ERRO   *",
                    MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
