using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sendmail
{
    public partial class frmSendmail : Form
    {
        public frmSendmail()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            // server field should be in the for server[:port]
            if (!Regex.IsMatch(tbSrv.Text, @"[a-zA-Z0-9]+(?:\:\d{,3})?"))
                return false;

            if (string.IsNullOrWhiteSpace((tbFrom.Text)))
                return false;

            if (string.IsNullOrWhiteSpace(tbTo.Text))
                return false;

            return true;
        }

        private void SendmailInit()
        {
            // Update UI to reflect background task.
            tbSrv.ReadOnly =
                tbFrom.ReadOnly =
                tbTo.ReadOnly =
                tbSubject.ReadOnly =
                tbCc.ReadOnly =
                tbBcc.ReadOnly =
                tbMessage.ReadOnly = true;

            btnSend.Enabled = false;
        }

        private void Sendmail()
        {
            var endpoint = tbSrv.Text.Split(':');
            int port;
            if (endpoint.Length != 2 || int.TryParse(endpoint[1], out port))
                port = 25;

            var mail = new MailMessage(tbFrom.Text.Trim(), tbTo.Text.Trim());
            // TODO Bcc
            // TODO Cc
            mail.Subject = tbSubject.Text;
            mail.Body = tbMessage.Text;

            using (var client = new SmtpClient
            {
                Port = port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = endpoint[0]
            })
            {
                client.Send(mail);
            }
        }

        private void SendmailComplete()
        {
            // Reset UI.
            tbSrv.ReadOnly =
                tbFrom.ReadOnly =
                tbTo.ReadOnly =
                tbSubject.ReadOnly =
                tbCc.ReadOnly =
                tbBcc.ReadOnly =
                tbMessage.ReadOnly = false;

            btnSend.Enabled = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            // Update UI to reflect background task.
            SendmailInit();

            var t = Task.Factory.StartNew(Sendmail);

            t.ContinueWith(_ =>
            {
                // Display results.
                if (t.Exception != null)
                    MessageBox.Show(string.Concat("An error occured while sending your message: ",
                        t.Exception.ToString()));
                else if (t.IsCanceled)
                {
                    // ...
                }
                else
                    MessageBox.Show("Your message has been sent successfully.");

                // Reset UI.
                SendmailComplete();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
