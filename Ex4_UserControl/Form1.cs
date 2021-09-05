using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4_UserControl
{
    public partial class Form1 : Form
    {

        private USLogin x;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = new USLogin();
            x.Dock = DockStyle.Fill;
            this.Controls.Add(x);
        }
    }
}
