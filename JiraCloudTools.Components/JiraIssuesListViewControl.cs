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
using AnotherJiraRestClient.JiraModel;

namespace JiraCloudTools.Components
{
    public partial class JiraIssuesListViewControl : UserControl
    {
        public JiraClient JiraClient { get; set; }

        public JiraIssuesListViewControl()
        {
            InitializeComponent();
        }


        public void DownloadIssues(List<AnotherJiraRestClient.JiraModel.Version> versions)
        {
            listView.BeginUpdate();


            listView.Groups.Clear();
            listView.Columns.Clear();
            listView.Items.Clear();

            listView.Columns.Add("Issue Key", "Issue Key");
            listView.Columns.Add("Summary", "Summary");

            foreach (AnotherJiraRestClient.JiraModel.Version v in versions)
            {
                ProjectMeta projectMeta = JiraClient.GetProjectMetaById(v.projectId);

                string jql = $"project = {v.projectId} AND fixVersion = {v.id}";
                List<string> fields = new List<string>() { "summary" };
                Issues issues = JiraClient.GetIssuesByJql(jql, 0, 10000, fields);


                ListViewGroup versionGroup = listView.Groups.Add(v.id, $"{projectMeta.name} - {v.name}");

                foreach (Issue issue in issues.issues)
                {
                    ListViewItem item = listView.Items.Add(issue.key);
                    item.SubItems.Add(issue.fields.summary);

                    item.Group = versionGroup;
                }
            }

            foreach (ColumnHeader header in listView.Columns)
            {
                header.Width = -1;
            }

            listView.View = View.Details;

            listView.EndUpdate();
        }

    }
}
