using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2()
        {
            InitializeComponent();
            //f = ff1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            f.textBox1.Text = this.textBox2.Text;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button1.Text = "Replace";
            this.button2.Text = "Cancel";
            this.label1.Text = "Find Text";
            this.label2.Text = "Replace With";
            this.button1.Enabled = false;

            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        { 
           
            this.button1.Enabled = true;
            
        }
    }
}
