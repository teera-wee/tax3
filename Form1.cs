using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double salary = 0, total = 0, discount = 0, vat = 0, baby = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                baby = 0;
            }
            else
            {
                baby = double.Parse(textBox6.Text);
            }
            discount = 60000;
            int son1 = 0, son2 = 0, disap = 0;
            if (radioButton1.Checked) discount += 0;
            if (radioButton2.Checked) discount += 60000;
            if (radioButton3.Checked) discount += 0;
            if (checkBox9.Checked) discount += 0;
            if (checkBox8.Checked) discount += 0;
            if (radioButton13.Checked) discount += 0;
            if (checkBox1.Checked) discount += 30000;
            if (checkBox2.Checked) discount += 30000;
            if (checkBox3.Checked) discount += 30000;
            if (checkBox4.Checked) discount += 30000;
            if (checkBox5.Checked)
            {
                son1 = 30000 * (int)numericUpDown1.Value;
                discount += son1;
            }
            if (checkBox6.Checked)
            {
                son2 = 60000 * (int)numericUpDown2.Value;
                discount += son2;
            }
            if (checkBox7.Checked)
            {
                disap = 60000 * (int)numericUpDown3.Value;
                discount += disap;
            }
            discount = discount + baby;
            textBox3.Text = discount.ToString("#,##0.00");
            textBox5.Text = total.ToString("#,##0.00");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salary = double.Parse(textBox1.Text);
            total = salary - discount;
            if (total >= 5000001)
            {
                vat = total * 35 / 100;
            }
            else if (total >= 2000001 && total <= 5000000)
            {
                vat = total * 30 / 100;
            }
            else if (total >= 1000001 && total <= 2000000)
            {
                vat = total * 25 / 100;
            }
            else if (total >= 750001 && total <= 1000000)
            {
                vat = total * 20 / 100;
            }
            else if (total >= 500001 && total <= 750000)
            {
                vat = total * 15 / 100;
            }
            else if (total >= 300001 && total <= 500000)
            {
                vat = total * 10 / 100;
            }
            else if (total >= 150001 && total <= 300000)
            {
                vat = total * 5 / 100;
            }
            else if (total <= 150000)
            {
                vat = 0;
            }


            if (total < 0)
            {
                total = 0;
            }

            textBox4.Text = vat.ToString("#,##0.00");
            textBox5.Text = total.ToString("#,##0.00");
            textBox6.Text = baby.ToString("#,##0.00");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = " ";
            textBox3.Text = "0.00";
            textBox4.Text = "0.00";
            textBox5.Text = "0.00";
            textBox6.Text = "0.00";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton13.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
