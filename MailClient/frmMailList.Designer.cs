
namespace MailClient
{
    partial class frmMailList
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcEmails = new DevExpress.XtraGrid.GridControl();
            this.gvEmails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlags = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganization = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImportance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSensitivity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessageId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInReplyTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tlFolders = new DevExpress.XtraTreeList.TreeList();
            this.tlcFolderName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1063, 46);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 339);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1063, 29);
            // 
            // gcEmails
            // 
            this.gcEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmails.Location = new System.Drawing.Point(279, 46);
            this.gcEmails.MainView = this.gvEmails;
            this.gcEmails.Name = "gcEmails";
            this.gcEmails.Size = new System.Drawing.Size(784, 293);
            this.gcEmails.TabIndex = 4;
            this.gcEmails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmails});
            // 
            // gvEmails
            // 
            this.gvEmails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUId,
            this.colSequenceNumber,
            this.colSize,
            this.colFlags,
            this.colDate,
            this.colSubject,
            this.colFrom,
            this.colSender,
            this.colOrganization,
            this.colImportance,
            this.colSensitivity,
            this.colMessageId,
            this.colInReplyTo,
            this.colComments,
            this.colSeen});
            this.gvEmails.GridControl = this.gcEmails;
            this.gvEmails.Name = "gvEmails";
            this.gvEmails.OptionsBehavior.Editable = false;
            this.gvEmails.OptionsBehavior.ReadOnly = true;
            this.gvEmails.OptionsDetail.AllowZoomDetail = false;
            this.gvEmails.OptionsDetail.EnableMasterViewMode = false;
            this.gvEmails.OptionsDetail.ShowDetailTabs = false;
            this.gvEmails.OptionsDetail.SmartDetailExpand = false;
            this.gvEmails.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvEmails_RowCellClick);
            // 
            // colUId
            // 
            this.colUId.FieldName = "UId";
            this.colUId.Name = "colUId";
            this.colUId.OptionsColumn.ReadOnly = true;
            // 
            // colSequenceNumber
            // 
            this.colSequenceNumber.FieldName = "SequenceNumber";
            this.colSequenceNumber.Name = "colSequenceNumber";
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.Name = "colSize";
            this.colSize.OptionsColumn.ReadOnly = true;
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 6;
            this.colSize.Width = 115;
            // 
            // colFlags
            // 
            this.colFlags.FieldName = "Flags";
            this.colFlags.Name = "colFlags";
            this.colFlags.OptionsColumn.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 85;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 1;
            this.colSubject.Width = 449;
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 2;
            this.colFrom.Width = 231;
            // 
            // colSender
            // 
            this.colSender.FieldName = "Sender";
            this.colSender.Name = "colSender";
            this.colSender.Width = 124;
            // 
            // colOrganization
            // 
            this.colOrganization.FieldName = "Organization";
            this.colOrganization.Name = "colOrganization";
            this.colOrganization.Visible = true;
            this.colOrganization.VisibleIndex = 3;
            this.colOrganization.Width = 115;
            // 
            // colImportance
            // 
            this.colImportance.FieldName = "Importance";
            this.colImportance.Name = "colImportance";
            this.colImportance.Visible = true;
            this.colImportance.VisibleIndex = 4;
            this.colImportance.Width = 115;
            // 
            // colSensitivity
            // 
            this.colSensitivity.FieldName = "Sensitivity";
            this.colSensitivity.Name = "colSensitivity";
            this.colSensitivity.Visible = true;
            this.colSensitivity.VisibleIndex = 5;
            this.colSensitivity.Width = 115;
            // 
            // colMessageId
            // 
            this.colMessageId.FieldName = "MessageId";
            this.colMessageId.Name = "colMessageId";
            // 
            // colInReplyTo
            // 
            this.colInReplyTo.FieldName = "InReplyTo";
            this.colInReplyTo.Name = "colInReplyTo";
            this.colInReplyTo.Visible = true;
            this.colInReplyTo.VisibleIndex = 7;
            this.colInReplyTo.Width = 115;
            // 
            // colComments
            // 
            this.colComments.FieldName = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.Visible = true;
            this.colComments.VisibleIndex = 8;
            this.colComments.Width = 115;
            // 
            // colSeen
            // 
            this.colSeen.FieldName = "Seen";
            this.colSeen.Name = "colSeen";
            this.colSeen.Visible = true;
            this.colSeen.VisibleIndex = 9;
            this.colSeen.Width = 151;
            // 
            // tlFolders
            // 
            this.tlFolders.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcFolderName});
            this.tlFolders.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlFolders.Location = new System.Drawing.Point(0, 46);
            this.tlFolders.Name = "tlFolders";
            this.tlFolders.Size = new System.Drawing.Size(279, 293);
            this.tlFolders.TabIndex = 5;
            this.tlFolders.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlFolders_FocusedNodeChanged);
            // 
            // tlcFolderName
            // 
            this.tlcFolderName.Caption = "Nazwa folderu";
            this.tlcFolderName.FieldName = "NazwaFolderu";
            this.tlcFolderName.Name = "tlcFolderName";
            this.tlcFolderName.OptionsColumn.AllowEdit = false;
            this.tlcFolderName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.tlcFolderName.Visible = true;
            this.tlcFolderName.VisibleIndex = 0;
            // 
            // frmMailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 368);
            this.Controls.Add(this.gcEmails);
            this.Controls.Add(this.tlFolders);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMailList";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Lista wiadomości";
            this.Load += new System.EventHandler(this.frmMailList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlFolders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gcEmails;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmails;
        private DevExpress.XtraGrid.Columns.GridColumn colUId;
        private DevExpress.XtraGrid.Columns.GridColumn colSequenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colFlags;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSender;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganization;
        private DevExpress.XtraGrid.Columns.GridColumn colImportance;
        private DevExpress.XtraGrid.Columns.GridColumn colSensitivity;
        private DevExpress.XtraGrid.Columns.GridColumn colMessageId;
        private DevExpress.XtraGrid.Columns.GridColumn colInReplyTo;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colSeen;
        private DevExpress.XtraTreeList.TreeList tlFolders;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcFolderName;
    }
}