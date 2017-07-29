namespace JiraProjects
{
    partial class JiraProjectsMainForm
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
            this.SuspendLayout();
            // 
            // jiraConnectBarControl1
            // 
            this.jiraConnectBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jiraConnectBarControl1.Location = new System.Drawing.Point(12, 12);
            this.jiraConnectBarControl1.Name = "jiraConnectBarControl1";
            this.jiraConnectBarControl1.Size = new System.Drawing.Size(928, 25);
            this.jiraConnectBarControl1.TabIndex = 0;
            // 
            // JiraProjectsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 451);
            this.Controls.Add(this.jiraConnectBarControl1);
            this.Name = "JiraProjectsMainForm";
            this.Text = "Jira Cloud Tools -Projec";
            this.ResumeLayout(false);

        }

        #endregion

        private JiraCloudTools.Components.JiraConnectBarControl jiraConnectBarControl1;
    }
}

