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
            button1.Size= new System.Drawing.Size(this.button1.Width, this.button1.Height);
            textBox1.Text=  button1.Size.Width.ToString();
            if (Width > 277)
                progressBar1.Value = 277;
            else
            progressBar1.Value = button1.Size.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size( Width+10, Height+10);
            if ((progressBar1.Value) <= 270)
                progressBar1.Value += 10;
            else progressBar1.Value = 277;
            textBox1.Text = button1.Width.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                 
                button1.Size = new System.Drawing.Size(Int32.Parse(textBox1.Text), Int32.Parse(textBox1.Text));
                if (Int32.Parse(textBox1.Text) > 277)
                    progressBar1.Value = 277;
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
            progressBar1.Value = e.X;
        }
    }


  /*  public class Model
    {
        private int value;
        public void setValue
        {
   value 
        }
    }*/
}
