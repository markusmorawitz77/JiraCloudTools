namespace JiraCloudTools.ProjectTree
{
    partial class ProjectTreeMainForm
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
            this.treeViewAdv = new Aga.Controls.Tree.TreeViewAdv();
            this.nodeTextBox = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.SuspendLayout();
            // 
            // jiraConnectBarControl
            // 
            this.jiraConnectBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jiraConnectBarControl.Location = new System.Drawing.Point(12, 12);
            this.jiraConnectBarControl.Name = "jiraConnectBarControl";
            this.jiraConnectBarControl.Size = new System.Drawing.Size(766, 25);
            this.jiraConnectBarControl.TabIndex = 0;
            this.jiraConnectBarControl.ConnectedToJiraClient += new System.EventHandler<JiraCloudTools.Components.JiraConnectBarControl.ConnectedEventArgs>(this.jiraConnectBarControl_ConnectedToJiraClient);
            // 
            // treeViewAdv
            // 
            this.treeViewAdv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewAdv.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdv.DefaultToolTipProvider = null;
            this.treeViewAdv.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdv.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdv.Location = new System.Drawing.Point(12, 43);
            this.treeViewAdv.Model = null;
            this.treeViewAdv.Name = "treeViewAdv";
            this.treeViewAdv.NodeControls.Add(this.nodeTextBox);
            this.treeViewAdv.SelectedNode = null;
            this.treeViewAdv.Size = new System.Drawing.Size(766, 358);
            this.treeViewAdv.TabIndex = 1;
            this.treeViewAdv.Text = "treeViewAdv1";
            // 
            // nodeTextBox
            // 
            this.nodeTextBox.DataPropertyName = "Text";
            this.nodeTextBox.EditEnabled = true;
            this.nodeTextBox.IncrementalSearchEnabled = true;
            this.nodeTextBox.LeftMargin = 3;
            this.nodeTextBox.ParentColumn = null;
            // 
            // ProjectTreeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 413);
            this.Controls.Add(this.treeViewAdv);
            this.Controls.Add(this.jiraConnectBarControl);
            this.Name = "ProjectTreeMainForm";
            this.Text = "Jira Cloud Tools - Project Tree";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.JiraConnectBarControl jiraConnectBarControl;
        private Aga.Controls.Tree.TreeViewAdv treeViewAdv;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox;
    }
}

