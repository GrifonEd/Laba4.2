using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба4Часть2_ООП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size( this.button1.Width+10, this.button1.Height + 10);
            if ((progressBar1.Value)<= 90)
            progressBar1.Value +=10;
            textBox1.Text = button1.Width.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                 
                button1.Size = new System.Drawing.Size(Int32.Parse(textBox1.Text), Int32.Parse(textBox1.Text));
                if (Int32.Parse(textBox1.Text) > 100)
                    progressBar1.Value = 100;
                else if (Int32.Parse(textBox1.Text) < 0)
                    progressBar1.Value = 0;
                else
                    progressBar1.Value = Int32.Parse(textBox1.Text);
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            button1.Size = new System.Drawing.Size(e.X, e.X);
        }
    }


  /*  public class Model
    {
        private int value;
        public void setValue
        {

        }
    }*/
}
