using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraCloudTools.ReportGenerator
{
    public partial class ReportGeneratorMainForm : Form
    {
        public ReportGeneratorMainForm()
        {
            InitializeComponent();
        }

        private void jiraConnectBarControl_ConnectedToJiraClient(object sender, Components.JiraConnectBarControl.ConnectedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.jiraProjectSelectorControl.JiraClient = e.JiraClient;
            this.jiraVersionsControl.JiraClient = e.JiraClient;

            this.jiraProjectSelectorControl.DownloadAllProjectsFromCloud();
        }

        private void jiraProjectSelectorControl_SelectedProjectsChanged(object sender, Components.JiraProjectSelectorControl.SelectedProjectsEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.jiraVersionsControl.DownloadVersionInfo(e.Projects);
        }
    }
}
