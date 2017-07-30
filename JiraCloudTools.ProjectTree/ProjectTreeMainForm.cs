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

namespace JiraCloudTools.ProjectTree
{
    public partial class ProjectTreeMainForm : Form
    {
        public ProjectTreeMainForm()
        {
            InitializeComponent();
        }

        private void jiraConnectBarControl_ConnectedToJiraClient(object sender, Components.JiraConnectBarControl.ConnectedEventArgs e)
        {
            JiraClient jc = e.JiraClient;

            List<Project> projects = jc.GetProjects();
            projects.Sort((x, y) => string.Compare(x.name, y.name));

            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            foreach (Project p in projects)
            {
                treeView.Nodes.Add(string.Format("{0}", p.name));
                
            }
            treeView.EndUpdate();



            listView.BeginUpdate();
            

            listView.EndUpdate();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
