using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class IdentityProviderListControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components;

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.ToolbarPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.NewAccountButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.ttp = new System.Windows.Forms.ToolTip(this.components);
        this.ToolbarPanel.SuspendLayout();
        base.SuspendLayout();
        this.ToolbarPanel.AutoScroll = true;
        this.ToolbarPanel.BackColor = System.Drawing.Color.White;
        this.ToolbarPanel.Controls.Add(this.NewAccountButton);
        this.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.ToolbarPanel.Location = new System.Drawing.Point(0, 0);
        this.ToolbarPanel.Name = "ToolbarPanel";
        this.ToolbarPanel.Padding = new System.Windows.Forms.Padding(10);
        this.ToolbarPanel.Size = new System.Drawing.Size(400, 42);
        this.ToolbarPanel.TabIndex = 0;
        this.ToolbarPanel.TemplateFile = null;
        
        this.NewAccountButton.Checked = false;
        this.NewAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        this.NewAccountButton.Image = Adaptive.Data.Vault.UI.Properties.Resources.Add16x16;
        this.NewAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.NewAccountButton.Location = new System.Drawing.Point(5, 5);
        this.NewAccountButton.Name = "NewAccountButton";
        this.NewAccountButton.Size = new System.Drawing.Size(265, 32);
        this.NewAccountButton.TabIndex = 0;
        this.NewAccountButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
        this.NewAccountButton.Text = "Create New ID Provider Entry...";
        this.NewAccountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
        this.ttp.SetToolTip(this.NewAccountButton, "Create a new entry to contain the login information for an identity provider, such as Microsoft, Google, Facebook, etc.");
        this.NewAccountButton.UseVisualStyleBackColor = true;

        this.ContainerPanel.AutoScroll = true;
        this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ContainerPanel.Location = new System.Drawing.Point(0, 42);
        this.ContainerPanel.Name = "ContainerPanel";
        this.ContainerPanel.Size = new System.Drawing.Size(400, 358);
        this.ContainerPanel.TabIndex = 1;
        this.ContainerPanel.TemplateFile = null;
        this.ttp.SetToolTip(this.ContainerPanel, "List if identity providers in this category.");
        this.BackColor = System.Drawing.Color.White;
        base.Controls.Add(this.ContainerPanel);
        base.Controls.Add(this.ToolbarPanel);
        base.Name = "IdentityProviderListControl";
        base.Size = new System.Drawing.Size(400, 400);
        this.ToolbarPanel.ResumeLayout(false);
        base.ResumeLayout(false);
    }

    #endregion

    private GradientPanel ToolbarPanel;
    private TemplatedButton NewAccountButton;
    private GradientPanel ContainerPanel;
    private ToolTip ttp;
}
