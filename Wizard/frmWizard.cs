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
    public partial class frmWizard : Form
    {
        public frmWizard(string lblTxt)
        {        
            InitializeComponent();
            //为区分每个form，用一个label显示不同的内容
            this.label1.Text = lblTxt;
        }
        //下一个form
        public frmWizard nextForm = null;
        //前一个form
        public frmWizard beforeForm = null;
        //back按钮按下
        private void btnBack_Click(object sender, EventArgs e)
        {
            if(beforeForm != null)
            {
                this.Visible = false;
                beforeForm.Show();
                //说明此时其前一个form是第一个form，不能按back
                if(beforeForm.beforeForm == null)
                {
                    beforeForm.btnBack.Enabled = false;
                }
            }
        }
        //next按钮按下
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nextForm != null)
            {
                this.Visible = false;
                //初始finish按钮设为不可按
                this.btnFinish.Enabled = false;
                nextForm.btnFinish.Enabled = false;
                nextForm.Show();
                //说明其下一个form是最后一个form，next按钮不可按，finish按钮可以按
                if(nextForm.nextForm == null)
                {
                    nextForm.btnNext.Enabled = false;
                    nextForm.btnFinish.Enabled = true;
                }
            }
        }
        //finish按钮按下
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //设置back按钮为灰色
        public void setBtnBackFalse()
        {
            this.btnBack.Enabled = false;
        }
        //设置finish按钮为灰色
        public void setBtnFinishFalse()
        {
            this.btnFinish.Enabled = false;
        }        
    }
}
