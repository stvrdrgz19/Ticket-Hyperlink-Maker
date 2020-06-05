using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Ticket_Hotlink_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                MessageBox.Show(Environment.CurrentDirectory);
                return;
                //if (!Directory.Exists(Environment.CurrentDirectory + "\\Logs"))
                //{
                //    MessageBox.Show("It doesn't exists!");
                //    return;
                //}
            }
            string var1 = @"=HYPERLINK(""https://salespad.atlassian.net/browse/";
            string var2 = @""")";
            List<string> rowList = new List<string>();
            List<string> finalList = new List<string>();

            // CHECK IF START TEXTBOX IS EMPTY
            if (String.IsNullOrWhiteSpace(tbText.Text))
            {
                string errorMessage = "Please enter text to process!";
                string errorCaption = "ERROR";
                MessageBoxButtons errorButton = MessageBoxButtons.OK;
                MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                DialogResult errorResult;

                errorResult = MessageBox.Show(errorMessage, errorCaption, errorButton, errorIcon);
                return;
            }
            // ACTIONS IF START TEXTBOX ISN'T EMPTY
            var result = tbText.Text.Split(new[] { '\n' });
            foreach (string x in result)
            {
                string sep = "\t";
                string[] col = x.Split(sep.ToCharArray());
                string y = var1 + col[0] + "\",\"" + col[1].Replace("\"", "\"\"") + var2 + "\t\t" + "Incomplete" + "\t\t\t\t" + col[2].Replace(";", " / ");
                rowList.Add(y);
            }

            // POPULATE RESULT TEXTBOX WITH FORMATTED TEXT
            string output = string.Join("\n", rowList.ToArray());
            string outputx = output.Replace("\n\n", "\n");
            tbResult.Text = outputx;
            return;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // CHECK IF RESULTS IS EMPTY
            if (String.IsNullOrWhiteSpace(tbResult.Text))
            {
                string errorMessage = "There are no results to copy!";
                string errorCaption = "ERROR";
                MessageBoxButtons errorButton = MessageBoxButtons.OK;
                MessageBoxIcon errorIcon = MessageBoxIcon.Error;
                DialogResult errorResult;

                errorResult = MessageBox.Show(errorMessage, errorCaption, errorButton, errorIcon);
                return;
            }
            // COPY RESULTS CONTENTS TO CLIPBOARD
            System.Windows.Forms.Clipboard.SetText(tbResult.Text);

            // INFORM THE USER THAT THE RESULTS WERE COPIED
            string successMessage = "Results were copied to the clipboard!";
            string successCaption = "SUCCESS";
            MessageBoxButtons successButton = MessageBoxButtons.OK;
            MessageBoxIcon successIcon = MessageBoxIcon.Exclamation;
            DialogResult successResult;

            successResult = MessageBox.Show(successMessage, successCaption, successButton, successIcon);
            return;
        }
    }
}
