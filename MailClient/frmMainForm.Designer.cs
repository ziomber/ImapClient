
namespace MailClient
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGetEmails = new DevExpress.XtraBars.BarButtonItem();
            this.bbiServer = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bbiPort = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bbiLogin = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bbiPassowrd = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiGetEmails,
            this.bbiServer,
            this.bbiPort,
            this.bbiLogin,
            this.bbiPassowrd,
            this.barMdiChildrenListItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barMdiChildrenListItem1);
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4});
            this.ribbonControl1.Size = new System.Drawing.Size(1112, 143);
            // 
            // bbiGetEmails
            // 
            this.bbiGetEmails.Caption = "Połącz";
            this.bbiGetEmails.Id = 1;
            this.bbiGetEmails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGetEmails.ImageOptions.Image")));
            this.bbiGetEmails.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGetEmails.ImageOptions.LargeImage")));
            this.bbiGetEmails.Name = "bbiGetEmails";
            this.bbiGetEmails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGetEmails_ItemClick);
            // 
            // bbiServer
            // 
            this.bbiServer.Caption = "Serwer";
            this.bbiServer.Edit = this.repositoryItemTextEdit1;
            this.bbiServer.EditValue = "imap.gmail.com";
            this.bbiServer.EditWidth = 150;
            this.bbiServer.Id = 2;
            this.bbiServer.Name = "bbiServer";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // bbiPort
            // 
            this.bbiPort.Caption = "Port  ";
            this.bbiPort.Edit = this.repositoryItemTextEdit2;
            this.bbiPort.EditValue = "993";
            this.bbiPort.Id = 3;
            this.bbiPort.Name = "bbiPort";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // bbiLogin
            // 
            this.bbiLogin.Caption = "Login   ";
            this.bbiLogin.Edit = this.repositoryItemTextEdit3;
            this.bbiLogin.EditValue = "test@gmail.com";
            this.bbiLogin.EditWidth = 150;
            this.bbiLogin.Id = 4;
            this.bbiLogin.Name = "bbiLogin";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // bbiPassowrd
            // 
            this.bbiPassowrd.Caption = "Hasło";
            this.bbiPassowrd.Edit = this.repositoryItemTextEdit4;
            this.bbiPassowrd.EditWidth = 150;
            this.bbiPassowrd.Id = 5;
            this.bbiPassowrd.Name = "bbiPassowrd";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            this.repositoryItemTextEdit4.PasswordChar = '*';
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 6;
            this.barMdiChildrenListItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.Image")));
            this.barMdiChildrenListItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.LargeImage")));
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Poczta";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGetEmails);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operacje";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiServer);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiLogin);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPort);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPassowrd);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Dane połaczenia";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 421);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Klient IMAP";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGetEmails;
        private DevExpress.XtraBars.BarEditItem bbiServer;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem bbiPort;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem bbiLogin;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem bbiPassowrd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
    }
}

