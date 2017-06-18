using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard
{
    public partial class frmHelp : Form
    {
        private frmHelp()
        {
            InitializeComponent();
        }
        //单例模式
        static frmHelp()
        {
            fh = new frmHelp();
        }
        private static frmHelp fh = null;
        public static frmHelp getFrmHelp()
        {
            return fh;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
