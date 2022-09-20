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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Hide();
            
            Form2 f2 = new Form2();
            if (f2.Visible == true)
            {
                f2.Visible = false;
            }
            else if (f2.Visible == false)
            {
                f2.ShowDialog();
                f2 = null;
                this.Show();
            }
            
        }
    }
}
