using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form6 : Form
    {
        public static Form6 instance;
        public TextBox tb1;
        public Form6()
        {
            InitializeComponent();
            this.AcceptButton = button1;
            //textBox1.Focus();
            instance = this;
            tb1 = textBox1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.Instance.tb1.Text = textBox1.Text;
            this.Close();
        }

        
    }
}
