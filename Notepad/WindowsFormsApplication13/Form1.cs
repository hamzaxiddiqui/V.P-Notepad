using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        //File 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled-Notepad";
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.textBox1.Dock = DockStyle.Fill;
            this.textBox1.CharacterCasing = CharacterCasing.Normal;
            this.normalToolStripMenuItem.Checked = true;
            this.copyToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Enabled = false;
            this.delToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Enabled = false;
            this.wordWrapToolStripMenuItem.CheckOnClick = false;
            this.textBox1.WordWrap = false;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O ;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.textBox1.Font = new Font("Lucida Console ",14);
            
            
            
             
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                wordWrapToolStripMenuItem.Checked=false;
                this.textBox1.WordWrap = false;
            }
            else if(this.wordWrapToolStripMenuItem.Checked==false)
            {
                this.wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
           
               
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;
                this.textBox1.Text=File.ReadAllText(filename);


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Modified == true)
            {
                save();
                Application.Exit();

            }
            else {
                this.textBox1.Modified = false;
                Application.Exit();
            
            }
                

            
        }

        private void uPPERCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.uPPERCaseToolStripMenuItem.Checked = true;
            if (this.uPPERCaseToolStripMenuItem.Checked == true)
            {
                this.textBox1.CharacterCasing = CharacterCasing.Upper;
                this.lowerCaseToolStripMenuItem.Checked= false;
                this.normalToolStripMenuItem.Checked= false;
               
            }
            
        }
        public void save() {

            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) {

                String fname = saveFileDialog1.FileName + ".txt";
                File.WriteAllText(fname,this.textBox1.Text);
                
            }
        }

        private void lowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.lowerCaseToolStripMenuItem.Checked = true;
            if (lowerCaseToolStripMenuItem.Checked == true)
            { 
                this.textBox1.CharacterCasing = CharacterCasing.Lower;
                this.uPPERCaseToolStripMenuItem.Checked = false;
                this.normalToolStripMenuItem.Checked = false;
                
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.normalToolStripMenuItem.Checked = true;
            if (normalToolStripMenuItem.Checked ==true) {
                this.textBox1.CharacterCasing = CharacterCasing.Normal;
                this.uPPERCaseToolStripMenuItem.Checked = false;
                this.lowerCaseToolStripMenuItem.Checked = false;
            }
        }

        private void aboutNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("China ka Notepad :P  ");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.textBox1.SelectAll();
                
                this.delToolStripMenuItem.Enabled = true;
                this.copyToolStripMenuItem.Enabled = true;
                this.cutToolStripMenuItem.Enabled = true;
                this.pasteToolStripMenuItem.Enabled = true;
             }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
            this.copyToolStripMenuItem.Enabled = false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
            this.cutToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Enabled = false;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            DialogResult dr =this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }

        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += System.DateTime.Today.ToString() +Environment.NewLine;
           
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.SelectionStart, this.textBox1.SelectionLength);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           saveFileDialog1.Filter = "(*.txt )|*.txt";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                String filename = saveFileDialog1.FileName;


                File.WriteAllText(filename, this.textBox1.Text);
            
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
