namespace Adaptive.Data.Vault.UI;

partial class WebAccountListControl
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
        ToolbarPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        NewAccountButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ToolbarPanel.SuspendLayout();
        SuspendLayout();
        // 
        // ToolbarPanel
        // 
        ToolbarPanel.AutoScroll = true;
        ToolbarPanel.BackColor = Color.White;
        ToolbarPanel.Controls.Add(NewAccountButton);
        ToolbarPanel.Dock = DockStyle.Top;
        ToolbarPanel.Location = new Point(0, 0);
        ToolbarPanel.Name = "ToolbarPanel";
        ToolbarPanel.Padding = new Padding(10);
        ToolbarPanel.Size = new Size(400, 42);
        ToolbarPanel.TabIndex = 0;
        ToolbarPanel.TemplateFile = null;
        // 
        // NewAccountButton
        // 
        NewAccountButton.Checked = false;
        NewAccountButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        NewAccountButton.Image = Properties.Resources.Add_16x16;
        NewAccountButton.ImageAlign = ContentAlignment.MiddleLeft;
        NewAccountButton.Location = new Point(5, 5);
        NewAccountButton.Name = "NewAccountButton";
        NewAccountButton.Size = new Size(247, 32);
        NewAccountButton.TabIndex = 0;
        NewAccountButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive Data Vault\\Resources\\ADV Button.template";
        NewAccountButton.Text = "Create New Account Entry...";
        NewAccountButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        NewAccountButton.UseVisualStyleBackColor = true;
        // 
        // ContainerPanel
        // 
        ContainerPanel.AutoScroll = true;
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(0, 42);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(400, 358);
        ContainerPanel.TabIndex = 1;
        ContainerPanel.TemplateFile = null;
        // 
        // WebAccountListControl
        // 
        BackColor = Color.White;
        Controls.Add(ContainerPanel);
        Controls.Add(ToolbarPanel);
        Name = "WebAccountListControl";
        Size = new Size(400, 400);
        ToolbarPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel ToolbarPanel;
    private Intelligence.Shared.UI.TemplatedButton NewAccountButton;
    private Intelligence.Shared.UI.GradientPanel ContainerPanel;
    
}
