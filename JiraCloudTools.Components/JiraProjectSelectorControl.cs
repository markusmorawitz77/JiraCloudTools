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
    public partial class JiraProjectSelectorControl : UserControl
    {
        public JiraClient JiraClient { get; set; }

        public class SelectedProjectsEventArgs : EventArgs
        {
            public List<Project> Projects { get; set; }
        }

        public event EventHandler<SelectedProjectsEventArgs> SelectedProjectsChanged;

        public JiraProjectSelectorControl()
        {
            InitializeComponent();
        }

        public void DownloadAllProjectsFromCloud()
        {
            if (JiraClient != null)
            { 
            List<Project> projects = JiraClient.GetProjects();
                projects.Sort((x, y) => string.Compare(x.name, y.name));

                listView.BeginUpdate();

                listView.Groups.Clear();
                listView.Columns.Clear();
                listView.Items.Clear();

                listView.Columns.Add("Project Name");
                listView.Columns.Add("Key");

                foreach (Project p in projects)
                {
                    ListViewItem item = new ListViewItem(p.name);
                    item.Tag = p;
                    item.SubItems.Add(p.key);

                    listView.Items.Add(item);
                }

                listView.View = View.Details;

                listView.Columns[0].Width = -1;
                listView.Columns[1].Width = -1;

                listView.EndUpdate();
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Project> projects = new List<Project>();
            SelectedProjectsEventArgs selectedProjectsEventArgs = new SelectedProjectsEventArgs();

            foreach (ListViewItem item in listView.SelectedItems)
            {
                projects.Add((Project)item.Tag);
            }

            selectedProjectsEventArgs.Projects = projects;
            SelectedProjectsChanged?.Invoke(this, selectedProjectsEventArgs);
        }
    }
}
