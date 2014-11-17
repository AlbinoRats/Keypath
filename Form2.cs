using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Keypath
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        private void Browse_Click_1(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void SettingLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string promptValue = ShowDialog("Keyword", "Add New","Directory");
            ListBox.Items.Add(promptValue);
        }
        private static string ShowDialog(string textlabel, string caption, string directorylabel)
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 220;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 20, Text = textlabel };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Label directoryLabel=new Label(){Left=50, Top=90, Text=directorylabel};
            TextBox directoryBox = new TextBox() { Left = 50, Top = 120, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 150 };
            Button folder = new Button() { Text = "Browse", Left = 355, Width = 70, Top = 119 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            //folder.Click += (sender, e) => { Browse_Click_1(sender, e); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(directoryLabel);
            prompt.Controls.Add(directoryBox);
            prompt.AcceptButton = confirmation;
            prompt.Controls.Add(folder);
            prompt.ShowDialog();
            return textBox.Text;

        }
        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
