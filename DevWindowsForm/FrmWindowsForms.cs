using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevWindowsForm
{
    public partial class FrmWindowsForms : Form
    {
        public FrmWindowsForms()
        {
            InitializeComponent();
        }

        private void FrmWindowsForms_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Millisecond.ToString();
        }
    }
}
