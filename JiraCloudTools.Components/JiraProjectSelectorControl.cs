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

        private int CompareProjects(Project x, Project y)
        {
            if (x.projectCategory != null && y.projectCategory != null)
            {
                if (x.projectCategory.id.Equals(y.projectCategory.id))
                {
                    return string.Compare(x.name, y.name);
                }
                else
                {
                    return string.Compare(x.projectCategory.name, y.projectCategory.name);
                }
            }
            else if (x.projectCategory == null && y.projectCategory == null)
            {
                return string.Compare(x.name, y.name);
            }
            else if (x.projectCategory == null && y.projectCategory != null)
            {
                return 1;
            }
            else if (x.projectCategory != null && y.projectCategory == null)
            {
                return -1;
            }
            return string.Compare(x.name, y.name);
        }

        public void DownloadAllProjectsFromCloud()
        {
            if (JiraClient != null)
            { 
            List<Project> projects = JiraClient.GetProjects();
                projects.Sort((x, y) => CompareProjects(x,y));

                listView.BeginUpdate();

                listView.Groups.Clear();
                listView.Columns.Clear();
                listView.Items.Clear();

                listView.ShowItemToolTips = true;
                listView.ShowGroups = true;

                listView.Groups.Add("No Category", "Projects without Category");

                listView.Columns.Add("Project Name", "Project Name");
                listView.Columns.Add("Key", "Key");
                listView.Columns.Add("Description", "Description");

                foreach (Project p in projects)
                {
                    ListViewItem item = new ListViewItem(p.name);
                    item.Tag = p;
                    item.SubItems.Add(p.key);
                    item.SubItems.Add(p.description);
                    item.ToolTipText = p.description;

                    if (p.projectCategory != null)
                    {
                        ListViewGroup g = listView.Groups[p.projectCategory.id];
                        if (g == null)
                            g = listView.Groups.Add(p.projectCategory.id, string.Format("{0} - {1}", p.projectCategory.name, p.projectCategory.description));
                        item.Group = g;
                    }
                    else
                    {
                        item.Group = listView.Groups["No Category"];
                    }

                    listView.Items.Add(item);
                }

                listView.View = View.Details;

                foreach(ColumnHeader c in listView.Columns)
                {
                    c.Width = -1;
                }
                listView.Columns["Description"].Width = 300;

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
