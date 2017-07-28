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

namespace JiraBase
{
    public partial class JiraConnectBarControl : UserControl
    {

        private JiraAccount JiraAccount { get; set; }
        public JiraClient JiraClient { get; private set; }


        public JiraConnectBarControl()
        {
            InitializeComponent();
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
        }

        private void disconnectToolStripButton_Click(object sender, EventArgs e)
        {
            this.JiraAccount = null;
            this.JiraClient = null;

            this.disconnectToolStripButton.Enabled = false;
            this.connectToolStripButton.Enabled = true;
            this.jiraServerToolStripComboBox.Enabled = true;
            this.userNameToolStripTextBox.Enabled = true;
            this.passwordToolStripTextBox.Enabled = true;
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
