namespace JiraCloudTools.ReportGenerator
{
    partial class ReportGeneratorMainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.jiraConnectBarControl = new JiraCloudTools.Components.JiraConnectBarControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.jiraProjectSelectorControl = new JiraCloudTools.Components.JiraProjectSelectorControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.jiraVersionsControl = new JiraCloudTools.Components.JiraVersionsControl();
            this.jiraIssuesListViewControl = new JiraCloudTools.Components.JiraIssuesListViewControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // jiraConnectBarControl
            // 
            this.jiraConnectBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jiraConnectBarControl.Location = new System.Drawing.Point(12, 12);
            this.jiraConnectBarControl.Name = "jiraConnectBarControl";
            this.jiraConnectBarControl.Size = new System.Drawing.Size(573, 25);
            this.jiraConnectBarControl.TabIndex = 0;
            this.jiraConnectBarControl.ConnectedToJiraClient += new System.EventHandler<JiraCloudTools.Components.JiraConnectBarControl.ConnectedEventArgs>(this.jiraConnectBarControl_ConnectedToJiraClient);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 43);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.jiraProjectSelectorControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(573, 287);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 1;
            // 
            // jiraProjectSelectorControl
            // 
            this.jiraProjectSelectorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jiraProjectSelectorControl.JiraClient = null;
            this.jiraProjectSelectorControl.Location = new System.Drawing.Point(0, 0);
            this.jiraProjectSelectorControl.Name = "jiraProjectSelectorControl";
            this.jiraProjectSelectorControl.Size = new System.Drawing.Size(191, 287);
            this.jiraProjectSelectorControl.TabIndex = 0;
            this.jiraProjectSelectorControl.SelectedProjectsChanged += new System.EventHandler<JiraCloudTools.Components.JiraProjectSelectorControl.SelectedProjectsEventArgs>(this.jiraProjectSelectorControl_SelectedProjectsChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.jiraVersionsControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.jiraIssuesListViewControl);
            this.splitContainer2.Size = new System.Drawing.Size(378, 287);
            this.splitContainer2.SplitterDistance = 126;
            this.splitContainer2.TabIndex = 0;
            // 
            // jiraVersionsControl
            // 
            this.jiraVersionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jiraVersionsControl.JiraClient = null;
            this.jiraVersionsControl.Location = new System.Drawing.Point(0, 0);
            this.jiraVersionsControl.Name = "jiraVersionsControl";
            this.jiraVersionsControl.Size = new System.Drawing.Size(126, 287);
            this.jiraVersionsControl.TabIndex = 0;
            this.jiraVersionsControl.SelectedVersionsChanged += new System.EventHandler<JiraCloudTools.Components.JiraVersionsControl.SelectedVersionsEventArgs>(this.jiraVersionsControl_SelectedVersionsChanged);
            // 
            // jiraIssuesListViewControl
            // 
            this.jiraIssuesListViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jiraIssuesListViewControl.Location = new System.Drawing.Point(0, 0);
            this.jiraIssuesListViewControl.Name = "jiraIssuesListViewControl";
            this.jiraIssuesListViewControl.Size = new System.Drawing.Size(248, 287);
            this.jiraIssuesListViewControl.TabIndex = 0;
            // 
            // ReportGeneratorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 342);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.jiraConnectBarControl);
            this.Name = "ReportGeneratorMainForm";
            this.Text = "Jira Cloud Tools - Report Generator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.JiraConnectBarControl jiraConnectBarControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Components.JiraProjectSelectorControl jiraProjectSelectorControl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Components.JiraVersionsControl jiraVersionsControl;
        private Components.JiraIssuesListViewControl jiraIssuesListViewControl;
    }
}

