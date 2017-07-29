using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnotherJiraRestClient;

namespace JiraCloudTools.Components
{
    public partial class JiraConnectBarControl : UserControl
    {
        public class ConnectedEventArgs: EventArgs
        {
            public JiraClient JiraClient { get; set; }
        }

        public class DisconnectedEventArgs : EventArgs
        {
            public JiraClient JiraClient { get; set; }
        }

        public event EventHandler<ConnectedEventArgs> ConnectedToJiraClient;
        public event EventHandler<DisconnectedEventArgs> DisconnectedFromJiraClient;

        private JiraAccount JiraAccount { get; set; }
        public JiraClient JiraClient { get; private set; }


        public JiraConnectBarControl()
        {
            InitializeComponent();
        }

        protected void OnConnectedToJiraClient(ConnectedEventArgs e)
        {
            ConnectedToJiraClient?.Invoke(this, e);
        }

        protected void OnDisconnectedToJiraClient(DisconnectedEventArgs e)
        {
            DisconnectedFromJiraClient?.Invoke(this, e);
        }

        private void connectToolStripButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.JiraAccount = new JiraAccount();
            this.JiraAccount.ServerUrl = this.jiraServerToolStripComboBox.Text;
            this.JiraAccount.User = this.userNameToolStripTextBox.Text;
            this.JiraAccount.Password = this.passwordToolStripTextBox.Text;

            this.JiraClient = new JiraClient(this.JiraAccount);

            try
            {
                this.JiraClient.GetProjects();
            }
            catch (Exception)
            {
                string failure = "Failure to connect to JIRA Cloud!";

                MessageBox.Show(failure, "Failure to conntct to Jira", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.JiraAccount = null;
                this.JiraClient = null;
                return;
            }

            this.disconnectToolStripButton.Enabled = true;
            this.connectToolStripButton.Enabled = false;
            this.jiraServerToolStripComboBox.Enabled = false;
            this.userNameToolStripTextBox.Enabled = false;
            this.passwordToolStripTextBox.Enabled = false;

            ConnectedEventArgs connectedEventArgs = new ConnectedEventArgs();
            connectedEventArgs.JiraClient = this.JiraClient;
            OnConnectedToJiraClient(connectedEventArgs);
        }

        private void disconnectToolStripButton_Click(object sender, EventArgs e)
        {
            DisconnectedEventArgs disconnectedEventArgs = new DisconnectedEventArgs();
            disconnectedEventArgs.JiraClient = this.JiraClient;

            this.JiraAccount = null;
            this.JiraClient = null;

            this.disconnectToolStripButton.Enabled = false;
            this.connectToolStripButton.Enabled = true;
            this.jiraServerToolStripComboBox.Enabled = true;
            this.userNameToolStripTextBox.Enabled = true;
            this.passwordToolStripTextBox.Enabled = true;

            OnDisconnectedToJiraClient(disconnectedEventArgs);
        }

        private void JiraConnectBarControl_Load(object sender, EventArgs e)
        {
            if (this.passwordToolStripTextBox.Control is TextBox)
            {
                TextBox tb = this.passwordToolStripTextBox.Control as TextBox;
                tb.PasswordChar = '*';
            }

            this.jiraServerToolStripComboBox.Text = "https://leister.atlassian.net";
            this.userNameToolStripTextBox.Text = "markus.morawitz";
        }
    }
}
