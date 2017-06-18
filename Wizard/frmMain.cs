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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private frmWizard form1 = null;
        private frmWizard form2 = null;
        private frmWizard form3 = null;

        private void btnWizard_Click(object sender, EventArgs e)
        {
            form1 = new frmWizard("f1");
            form2 = new frmWizard("f2");
            form3 = new frmWizard("f3");
            //form1->form2->form3
            form1.nextForm = form2;
            form2.nextForm = form3;
            form2.beforeForm = form1;
            form3.beforeForm = form2;
            //设置第一个form的back按钮finish按钮不可按
            form1.setBtnBackFalse();
            form1.setBtnFinishFalse();
            form1.Show();         
        }
        //获取帮助界面（采用了单例模式）
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {        
            if(e.KeyData == Keys.F1)
            {
                frmHelp fh = frmHelp.getFrmHelp();
                fh.Show();
            }
        }
    }
}
