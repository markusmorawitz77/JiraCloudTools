namespace JiraCloudTools.VersionOverview
{
    partial class VersionOverviewMainForm
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
            this.jiraConnectBarControl1 = new JiraCloudTools.Components.JiraConnectBarControl();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.jiraProjectSelectorControl = new JiraCloudTools.Components.JiraProjectSelectorControl();
            this.jiraVersionsControl = new JiraCloudTools.Components.JiraVersionsControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // jiraConnectBarControl1
            // 
            this.jiraConnectBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jiraConnectBarControl1.Location = new System.Drawing.Point(12, 12);
            this.jiraConnectBarControl1.Name = "jiraConnectBarControl1";
            this.jiraConnectBarControl1.Size = new System.Drawing.Size(891, 25);
            this.jiraConnectBarControl1.TabIndex = 0;
            this.jiraConnectBarControl1.ConnectedToJiraClient += new System.EventHandler<JiraCloudTools.Components.JiraConnectBarControl.ConnectedEventArgs>(this.jiraConnectBarControl1_ConnectedToJiraClient);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(12, 43);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.jiraProjectSelectorControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.jiraVersionsControl);
            this.splitContainer.Size = new System.Drawing.Size(891, 324);
            this.splitContainer.SplitterDistance = 253;
            this.splitContainer.TabIndex = 1;
            // 
            // jiraProjectSelectorControl
            // 
            this.jiraProjectSelectorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jiraProjectSelectorControl.JiraClient = null;
            this.jiraProjectSelectorControl.Location = new System.Drawing.Point(3, 3);
            this.jiraProjectSelectorControl.Name = "jiraProjectSelectorControl";
            this.jiraProjectSelectorControl.Size = new System.Drawing.Size(245, 316);
            this.jiraProjectSelectorControl.TabIndex = 1;
            this.jiraProjectSelectorControl.SelectedProjectsChanged += new System.EventHandler<JiraCloudTools.Components.JiraProjectSelectorControl.SelectedProjectsEventArgs>(this.jiraProjectSelectorControl_SelectedProjectsChanged);
            // 
            // jiraVersionsControl
            // 
            this.jiraVersionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jiraVersionsControl.JiraClient = null;
            this.jiraVersionsControl.Location = new System.Drawing.Point(0, 0);
            this.jiraVersionsControl.Name = "jiraVersionsControl";
            this.jiraVersionsControl.Size = new System.Drawing.Size(632, 322);
            this.jiraVersionsControl.TabIndex = 0;
            // 
            // VersionOverviewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 379);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.jiraConnectBarControl1);
            this.Name = "VersionOverviewMainForm";
            this.Text = "Jira Cloud Tools - Version Overview";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.JiraConnectBarControl jiraConnectBarControl1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Components.JiraProjectSelectorControl jiraProjectSelectorControl;
        private Components.JiraVersionsControl jiraVersionsControl;
    }
}

