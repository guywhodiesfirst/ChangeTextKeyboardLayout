using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLayoutGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string textToConvert = textBox1.Text;
            string result;
            if(EngToUkr.Checked)
            {
                result = KeyboardLayout.ConvertEngToUkr(textToConvert);
            }
            else
            {
                result = KeyboardLayout.ConvertUkrToEng(textToConvert);
            }

            textBox2.Text = result;
        }
    }
}
