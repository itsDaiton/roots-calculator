using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roots_Calculator
{
    public partial class FormMain : Form
    {
        string info;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tbResult.Text = Calculating.Calculate(tbNum.Text, tbRoot.Text, out info);
            rtbInfo.Text = info;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            info = "x = decimal number\nn = root index";
            rtbInfo.Text = info;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Calculating.Clear(tbNum, tbRoot, tbResult, out info);
            rtbInfo.Text = info;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            tbResult.Text = Calculating.SquareRoot(tbNum.Text, out info);
            rtbInfo.Text = info;
        }

        private void btnCbrt_Click(object sender, EventArgs e)
        {
            tbResult.Text = Calculating.CubeRoot(tbNum.Text, out info);
            rtbInfo.Text = info;
        }
    }
}
