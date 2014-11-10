using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Keypath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Password_Keydown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
            {
                this.Close();
            }
            
        }
        //border 1pixel solid black
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        //private void Form_Resize(object sender, EventArgs e)
        //{
        //    if (WindowState == FormWindowState.Minimized)
        //    {
        //        this.Hide();
        //    }
        //}
        //private void notifyIcon_Click(object sender, EventArgs e)
        //{
        //    this.Show();
        //    this.WindowState = FormWindowState.Normal;
        //}
        
        private void form1_LostFocus(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
        }

        // This method handles the LostFocus event for textBox1 by setting the  
        // dialog's InitialDirectory property to the text in textBox1. 
        //private void textBox1_LostFocus(object sender, System.EventArgs e)
        //{
        //    openFileDialog1.InitialDirectory = Password_txt.Text;
        //}

        //// This method demonstrates using the ErrorProvider.GetError method  
        //// to check for an error before opening the dialog box. 
        //private void button1_Click(System.Object sender, System.EventArgs e)
        //{
        //    //If there is no error, then open the dialog box. 
        //    if (errorProvider1.GetError(Password_txt) == "")
        //    {
        //        DialogResult dialogResult = openFileDialog1.ShowDialog();
        //    }
        //}
    }
}
