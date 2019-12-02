using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(boxNumber1.Text);
                float number2 = float.Parse(boxNumber2.Text);
                float result = number1 + number2;
                boxAnswer.Text = result.ToString();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(boxNumber1.Text);
                float number2 = float.Parse(boxNumber2.Text);
                float result = number1 - number2;
                boxAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(boxNumber1.Text);
                float number2 = float.Parse(boxNumber2.Text);
                float result = number1 * number2;
                boxAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                float number1 = float.Parse(boxNumber1.Text);
                float number2 = float.Parse(boxNumber2.Text);
                float result = number1 / number2;
                boxAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
