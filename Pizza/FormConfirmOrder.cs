using Pizza.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FormConfirmOrder : Form
    {
        public FormConfirmOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Main1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.User1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Wassim\Pictures\Screenshots\User2.png");
        }
    }
}
