using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wpfuc = WpfInForm.UserControl1;

namespace WpfInForm
{
    public partial class Form1 : Form
    {
        wpfuc uc;
        public Form1()
        {
            InitializeComponent();
            uc = elementHost1.Child as wpfuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc.wpftree.Items.Add("Hello");
        }
    }
}
