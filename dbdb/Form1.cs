using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dbdb
{

    public partial class Form1 : Form
    {
        int i, j, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(t1.Text);
            this.j = int.Parse(t2.Text);
            this.sum = this.i + this.j;
            result.Text = this.sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            i = int.Parse(t1.Text);
            j = int.Parse(t2.Text);
            sum = i - j;
            result.Text = sum.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            i = int.Parse(t1.Text);
            j = int.Parse(t2.Text);
            sum = i * j;
            result.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = int.Parse(t1.Text);
            j = int.Parse(t2.Text);
            sum = i / j;
            result.Text = sum.ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            this.i = int.Parse(t1.Text);
            this.j = int.Parse(t2.Text);
            this.sum = this.i + this.j;
            result.Text = this.sum.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            i = int.Parse(t1.Text);
            j = int.Parse(t2.Text);
            sum = i - j;
            result.Text = sum.ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            i = int.Parse(t1.Text);
            j = int.Parse(t2.Text);
            sum = i * j;
            result.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime dtTemp = DateTime.Today;
            switch (dtTemp.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Monday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Tuesday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Wednesday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Thursday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Friday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

                case DayOfWeek.Saturday:
                    MessageBox.Show("Today is Sunday\n" + DateTime.Today);
                    break;

            }
        }
    }
}
