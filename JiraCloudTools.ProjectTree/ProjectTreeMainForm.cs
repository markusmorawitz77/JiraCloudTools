using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnotherJiraRestClient;
using JiraCloudTools.Components;
using AnotherJiraRestClient.JiraModel;
using Aga.Controls.Tree;

namespace JiraCloudTools.ProjectTree
{
    public partial class ProjectTreeMainForm : Form
    {
        private JiraClient JiraClient { get; set; }

        public ProjectTreeMainForm()
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

        private void jiraConnectBarControl_ConnectedToJiraClient(object sender, Components.JiraConnectBarControl.ConnectedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            JiraClient = e.JiraClient;

            List<Project> projects = JiraClient.GetProjects();
            projects.Sort((x, y) => CompareProjects(x,y));

            treeViewAdv.BeginUpdate();
            TreeModel model = new TreeModel();
            treeViewAdv.Model = model;
            
            foreach (Project p in projects)
            {
                model.Nodes.Add(new Node(p.name));
            }

            treeViewAdv.EndUpdate();
        }

        
    }
}
