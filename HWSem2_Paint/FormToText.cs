using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWSem2_Paint
{
    public partial class FormToText : Form
    {
        public FormToText()
        {
            InitializeComponent();
        }

        public string ftText = "";

        private void button1_Click(object sender, EventArgs e)
        {
            ftText = textBox1.Text;
            this.Close();
        }
    }
}
