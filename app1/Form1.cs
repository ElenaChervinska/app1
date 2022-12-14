using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    public partial class Form1 : Form
    {
        SoftwareList list = new SoftwareList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in list.Softwares)
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in list.FindByName(textBox1.Text))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in list.FindByAnnotation(textBox2.Text))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in list.FindByAuthor(textBox3.Text))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                list.AddSoft(new Software(t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text));
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                list.EditSoft(new Software(t7.Text, t8.Text, t9.Text, t10.Text, t11.Text, t12.Text));
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                list.DeleteSoft(t13.Text);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.LoadFromFile();
            MessageBox.Show("Завантажено з файлу");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            list.LoadToFile();
            MessageBox.Show("збережено до файлу");
        }
    }
}
