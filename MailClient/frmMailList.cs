using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using ImapX;
using ImapX.Collections;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace MailClient
{
    public partial class frmMailList : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ImapClient _ImapClient { get; set; }
        private string _serverName { get; set; }
        private int _sererPort { get; set; }
        private string _login { get; set; }
        private string _password { get; set; }

        public frmMailList()
        {
            InitializeComponent();
        }

        private void GetNodesFromFolders(FolderCollection folders, TreeListNode root)
        {
            foreach (var folder in folders)
            {
                tlFolders.AppendNode(new object[] { folder.Name }, root, folder.Path);
                if (folder.HasChildren)
                    GetNodesFromFolders(folder.SubFolders, tlFolders.Nodes.LastNode);
            }
        }

        internal void Connect(string serverName, int serverPort, string login, string password)
        {
            _serverName = serverName;
            _sererPort = serverPort;
            _login = login;
            _password = password;

            Text = $"Poczta dla adresu {_login} ({_serverName})";
        }

        private void tlFolders_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (_ImapClient != null)
            {
                Folder f = _ImapClient.Folders.Find(e.Node.Tag.ToString());
                if (f != null)
                {
                    BackgroundWorker bw = new BackgroundWorker() { WorkerReportsProgress = false, WorkerSupportsCancellation = false };
                    bw.DoWork += (s, ev) =>
                    {
                        if (f.Selectable)
                            ev.Result = f.Search("ALL", ImapX.Enums.MessageFetchMode.Minimal);
                    };
                    bw.RunWorkerCompleted += (s, ev) =>
                    {
                        if (ev.Result != null && ev.Error == null && !ev.Cancelled)
                            gcEmails.DataSource = ev.Result;
                    };
                    bw.RunWorkerAsync();
                }
            }
        }

        private void gvEmails_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks > 1 && gvEmails.IsValidRowHandle(e.RowHandle))
            {
                var row = gvEmails.GetRow(e.RowHandle) as ImapX.Message;
                var currFolder = _ImapClient.Folders.Find(tlFolders.FocusedNode.Tag.ToString());
                var message = currFolder.Search(new long[] { row.UId }, ImapX.Enums.MessageFetchMode.Full).FirstOrDefault();
                if (message != null)
                {
                    string caption = $"Podgląd maila: {message.Subject}";
                    var frm = MdiParent.MdiChildren.Where(_ => _.GetType() == typeof(frmMailPreview) && _.Text.Equals(caption)).FirstOrDefault();
                    if (frm != null)
                        frm.BringToFront();
                    else
                    {
                        frmMailPreview mail = new frmMailPreview() 
                        { 
                            MdiParent = this.MdiParent, 
                            Text = caption, 
                            WindowState = this.WindowState 
                        };
                        mail.MailDeleted += (s, ev) =>
                        {
                            tlFolders_FocusedNodeChanged(s, new FocusedNodeChangedEventArgs(tlFolders.FocusedNode, tlFolders.FocusedNode));
                        };
                        mail.SetMessage(message);
                        mail.Show();
                    }
                }
            }
        }

        private void frmMailList_Load(object sender, EventArgs e)
        {
            // https://support.google.com/mail/thread/21528208?hl=en
            _ImapClient = new ImapClient(_serverName, _sererPort, System.Security.Authentication.SslProtocols.Tls, true);
            if (_ImapClient.Connect())
            {
                if (_ImapClient.Login(_login, _password))
                {
                    GetNodesFromFolders(_ImapClient.Folders, null);
                    tlFolders.FocusedNode = tlFolders.Nodes.FirstNode;
                }
            }
        }
    }
}