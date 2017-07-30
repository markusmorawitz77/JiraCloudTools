namespace JiraCloudTools.Components
{
    partial class JiraConnectBarControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JiraConnectBarControl));
            this.jiraClientToolStrip = new System.Windows.Forms.ToolStrip();
            this.jiraServerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.jiraServerToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passwordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.disconnectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.jiraClientToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // jiraClientToolStrip
            // 
            this.jiraClientToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jiraServerToolStripLabel,
            this.jiraServerToolStripComboBox,
            this.toolStripSeparator2,
            this.userNameToolStripLabel,
            this.userNameToolStripTextBox,
            this.toolStripSeparator1,
            this.passwordToolStripLabel,
            this.passwordToolStripTextBox,
            this.toolStripSeparator3,
            this.connectToolStripButton,
            this.disconnectToolStripButton});
            this.jiraClientToolStrip.Location = new System.Drawing.Point(0, 0);
            this.jiraClientToolStrip.Name = "jiraClientToolStrip";
            this.jiraClientToolStrip.Size = new System.Drawing.Size(897, 25);
            this.jiraClientToolStrip.TabIndex = 1;
            this.jiraClientToolStrip.Text = "Jira Client";
            // 
            // jiraServerToolStripLabel
            // 
            this.jiraServerToolStripLabel.Name = "jiraServerToolStripLabel";
            this.jiraServerToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.jiraServerToolStripLabel.Text = "Server:";
            // 
            // jiraServerToolStripComboBox
            // 
            this.jiraServerToolStripComboBox.Name = "jiraServerToolStripComboBox";
            this.jiraServerToolStripComboBox.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // userNameToolStripLabel
            // 
            this.userNameToolStripLabel.Name = "userNameToolStripLabel";
            this.userNameToolStripLabel.Size = new System.Drawing.Size(68, 22);
            this.userNameToolStripLabel.Text = "User Name:";
            // 
            // userNameToolStripTextBox
            // 
            this.userNameToolStripTextBox.Name = "userNameToolStripTextBox";
            this.userNameToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // passwordToolStripLabel
            // 
            this.passwordToolStripLabel.Name = "passwordToolStripLabel";
            this.passwordToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.passwordToolStripLabel.Text = "Password:";
            // 
            // passwordToolStripTextBox
            // 
            this.passwordToolStripTextBox.Name = "passwordToolStripTextBox";
            this.passwordToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // connectToolStripButton
            // 
            this.connectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripButton.Image")));
            this.connectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToolStripButton.Name = "connectToolStripButton";
            this.connectToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.connectToolStripButton.Text = "Connect";
            this.connectToolStripButton.Click += new System.EventHandler(this.connectToolStripButton_Click);
            // 
            // disconnectToolStripButton
            // 
            this.disconnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.disconnectToolStripButton.Enabled = false;
            this.disconnectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("disconnectToolStripButton.Image")));
            this.disconnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disconnectToolStripButton.Name = "disconnectToolStripButton";
            this.disconnectToolStripButton.Size = new System.Drawing.Size(70, 22);
            this.disconnectToolStripButton.Text = "Disconnect";
            this.disconnectToolStripButton.Click += new System.EventHandler(this.disconnectToolStripButton_Click);
            // 
            // JiraConnectBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jiraClientToolStrip);
            this.Name = "JiraConnectBarControl";
            this.Size = new System.Drawing.Size(897, 25);
            this.Load += new System.EventHandler(this.JiraConnectBarControl_Load);
            this.jiraClientToolStrip.ResumeLayout(false);
            this.jiraClientToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip jiraClientToolStrip;
        private System.Windows.Forms.ToolStripLabel jiraServerToolStripLabel;
        private System.Windows.Forms.ToolStripComboBox jiraServerToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel userNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userNameToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel passwordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passwordToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton connectToolStripButton;
        private System.Windows.Forms.ToolStripButton disconnectToolStripButton;
    }
}
