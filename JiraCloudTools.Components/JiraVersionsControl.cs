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
    public partial class JiraVersionsControl : UserControl
    {
        public JiraClient JiraClient { get; set; }

        public JiraVersionsControl()
        {
            InitializeComponent();
        }

        public void DownloadVersionInfo(List<Project> projects)
        {
            if (JiraClient != null)
            {
                listView.BeginUpdate();
                listView.Columns.Clear();
                listView.Groups.Clear();
                listView.Items.Clear();

                listView.Columns.Add("Version Name");
                listView.Columns.Add("Version ID");
                listView.Columns.Add("Description");
                listView.Columns.Add("Release State");
                listView.Columns.Add("Release Date");
                listView.Columns.Add("Project Key");

                foreach (Project p in projects)
                {
                    ListViewGroup g = listView.Groups.Add(p.key, p.name);

                    List<AnotherJiraRestClient.JiraModel.Version> versions;
                    versions = JiraClient.GetVersions(p.key) as List<AnotherJiraRestClient.JiraModel.Version>;

                    foreach (var v in versions)
                    {
                        ListViewItem li = listView.Items.Add(v.name);
                        li.Group = g;
                        li.Tag = v;
                        li.SubItems.Add(v.id);
                        li.SubItems.Add(v.description);

                        string releaseState = "Not Released";
                        string releaseDate = v.userReleaseDate;

                        if (v.released) {
                            releaseState = "Released";
                            releaseDate = v.releaseDate.ToShortDateString();
                        }
                        if (v.archived)
                        {
                            releaseState += " (Archived)";
                        }

                        li.SubItems.Add(releaseState);
                        li.SubItems.Add(releaseDate);
                        li.SubItems.Add(p.key);
                    }

                }

                listView.View = View.Details;

                foreach(ColumnHeader c in listView.Columns)
                {
                    c.Width = -1;
                }
                if (listView.Columns[2].Width > 300) listView.Columns[2].Width = 300;

                listView.EndUpdate();
            }
        }
    }
}
