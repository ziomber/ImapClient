using System;

namespace MailClient
{

    public partial class frmMailPreview : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private ImapX.Message _message { get; set; }

        public event EventHandler MailDeleted; 

        public frmMailPreview()
        {
            InitializeComponent();
        }

        internal void SetMessage(ImapX.Message message)
        {
            _message = message;
        }

        protected virtual void OnMailDeleted(EventArgs e)
        {
            MailDeleted?.Invoke(this, e);
        }

        private void frmMailPreview_Load(object sender, EventArgs e)
        {
            if (_message != null && _message.Body != null)
            {
                if (_message.Body.HasHtml)
                    wbMessageBody.DocumentText = _message.Body.Html;
                else
                    wbMessageBody.DocumentText = _message.Body.Text;
            }
            else
                wbMessageBody.Navigate("about:blank");

            teFrom.Text = _message.From.ToString();
            teTitle.Text = _message.Subject;
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _message.Remove();
            Close();
            OnMailDeleted(EventArgs.Empty);
        }
    }
}