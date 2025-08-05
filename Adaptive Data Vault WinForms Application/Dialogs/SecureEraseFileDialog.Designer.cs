namespace Adaptive.Data.Vault.UI;

partial class SecureEraseFileDialog
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
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        ButtonBar = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        BorderPanel.SuspendLayout();
        ContainerPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContainerPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(800, 450);
        BorderPanel.TabIndex = 0;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(ButtonBar);
        ContainerPanel.Controls.Add(Header);
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(5, 5);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(790, 440);
        ContainerPanel.TabIndex = 0;
        ContainerPanel.TemplateFile = null;
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(790, 60);
        Header.TabIndex = 0;
        Header.TitleText = "ADAPTIVE DATA VAULT";
        // 
        // ButtonBar
        // 
        ButtonBar.CancelEnabled = true;
        ButtonBar.CancelText = "Cancel";
        ButtonBar.CancelVisible = true;
        ButtonBar.Dock = DockStyle.Bottom;
        ButtonBar.Font = new Font("Segoe UI", 9.75F);
        ButtonBar.Location = new Point(0, 400);
        ButtonBar.Margin = new Padding(48, 22, 48, 22);
        ButtonBar.Name = "ButtonBar";
        ButtonBar.SaveEnabled = true;
        ButtonBar.SaveText = "Save";
        ButtonBar.SaveVisible = true;
        ButtonBar.Size = new Size(790, 40);
        ButtonBar.TabIndex = 1;
        // 
        // SecureEraseFileDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "SecureEraseFileDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContainerPanel;
    private Controls.SaveCancelBar ButtonBar;
    private Controls.VaultDialogHeader Header;
}