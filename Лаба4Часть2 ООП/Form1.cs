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
        int milky = 22;
        int way = 4;
        public Form1()
        {
            InitializeComponent();
            button1.Size= new System.Drawing.Size(milky, milky);
            textBox1.Text=  milky.ToString();
            progressBar1.Value = (int)(milky / 2.77);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size( this.button1.Width+10, this.button1.Height + 10);
            if ((progressBar1.Value)<= 97)
            progressBar1.Value += (int)(10/2.77);
            else progressBar1.Value = 100;
            textBox1.Text = button1.Width.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                 
                button1.Size = new System.Drawing.Size(Int32.Parse(textBox1.Text), Int32.Parse(textBox1.Text));
                if (Int32.Parse(textBox1.Text) > 277)
                    progressBar1.Value = 100;
                else if (Int32.Parse(textBox1.Text) < 0)
                    progressBar1.Value = 0;
                else
                    progressBar1.Value = (int)(Int32.Parse(textBox1.Text)/2.77);
            }
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {

            textBox1.Text = e.X.ToString();
            button1.Size = new System.Drawing.Size(e.X, e.X);
            progressBar1.Value = (int)(e.X/2.77);
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
