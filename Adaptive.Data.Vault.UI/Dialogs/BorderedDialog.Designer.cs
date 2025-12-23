namespace Adaptive.Data.Vault.UI;

partial class BorderedDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorderedDialog));
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        SuspendLayout();
        // 
        // ContainerPanel
        // 
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(0, 0);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Padding = new Padding(5);
        ContainerPanel.Size = new Size(800, 450);
        ContainerPanel.TabIndex = 0;
        ContainerPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        // 
        // BorderedDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        ControlBox = false;
        Controls.Add(ContainerPanel);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "BorderedDialog";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }

    #endregion

    public Intelligence.Shared.UI.GradientPanel ContainerPanel;
}