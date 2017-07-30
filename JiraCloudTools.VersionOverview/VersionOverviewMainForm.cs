using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraCloudTools.VersionOverview
{
    public partial class VersionOverviewMainForm : Form
    {
        public VersionOverviewMainForm()
        {
            InitializeComponent();
        }

        private void jiraConnectBarControl1_ConnectedToJiraClient(object sender, Components.JiraConnectBarControl.ConnectedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            this.jiraProjectSelectorControl.JiraClient = e.JiraClient;
            this.jiraVersionsControl.JiraClient = e.JiraClient;

            this.jiraProjectSelectorControl.DownloadAllProjectsFromCloud();
        }

        private void jiraProjectSelectorControl_SelectedProjectsChanged(object sender, Components.JiraProjectSelectorControl.SelectedProjectsEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            jiraVersionsControl.DownloadVersionInfo(e.Projects);
        }
    }
}
