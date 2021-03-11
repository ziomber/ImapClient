using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MailClient
{
    public partial class frmMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void bbiGetEmails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = MdiChildren.Where(_ => _.GetType() == typeof(frmMailList)).FirstOrDefault();
            if (frm != null)
                frm.BringToFront();
            else
            {
                frmMailList list = new frmMailList()
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                list.Connect(bbiServer.EditValue.ToString(), Convert.ToInt32(bbiPort.EditValue), bbiLogin.EditValue.ToString(), bbiPassowrd.EditValue.ToString());
                list.Show();
            }
        }

        private void barMdiChildrenListItem1_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

        }
    }
}
