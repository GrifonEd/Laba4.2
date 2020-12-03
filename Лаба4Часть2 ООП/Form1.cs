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
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.setValue(model.getValue() + 10); 
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                model.setValue(Int32.Parse(textBox1.Text));
            }
            
        }

        private void progressBar1_MouseMove(object sender, MouseEventArgs e)
        {

            model.setValue(e.X);
        }
        private void UpdateFromModel(object sender,EventArgs e)
        {
            textBox1.Text = model.getValue().ToString();
            progressBar1.Value = model.getValue();
            button1.Size = new System.Drawing.Size(model.getValue(), model.getValue());
        }
    }
    class Model
    {
        public System.EventHandler observers;  
        private int value;
        public void setValue(int value)
        {
            if (value > 277)
                this.value = 277;
            else if (value < 0)
                this.value = 0;
            else this.value = value;

            observers.Invoke(this, null);
        }
        public int getValue()
        {
            return value;
        }
    }
}
