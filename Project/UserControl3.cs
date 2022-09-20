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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            userControl51.Show();
            userControl41.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            userControl41.Show();
            userControl51.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
