using Adaptive.Data.Vault.UI.Controls;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class DecodeSecureMessageDialog
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
        this.components = new System.ComponentModel.Container();
        this.MessageText = new System.Windows.Forms.TextBox();
        this.BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        this.PrepareButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.MessageHeader = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        this.ButtonBar = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        this.Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        this.ttp = new System.Windows.Forms.ToolTip(this.components);
        this.FileButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        this.BorderPanel.SuspendLayout();
        this.ContainerPanel.SuspendLayout();
        this.ContentPanel.SuspendLayout();
        base.SuspendLayout();
        this.MessageText.AcceptsReturn = true;
        this.MessageText.AcceptsTab = true;
        this.MessageText.BackColor = System.Drawing.Color.Black;
        this.MessageText.Dock = System.Windows.Forms.DockStyle.Top;
        this.MessageText.Font = new System.Drawing.Font("Consolas", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
        this.MessageText.ForeColor = System.Drawing.Color.DarkGreen;
        this.MessageText.Location = new System.Drawing.Point(5, 25);
        this.MessageText.Multiline = true;
        this.MessageText.Name = "MessageText";
        this.MessageText.PlaceholderText = "(Enter Message Here or Paste the Text from the Clipboard.)";
        this.MessageText.Size = new System.Drawing.Size(625, 420);
        this.MessageText.TabIndex = 1;
        this.ttp.SetToolTip(this.MessageText, "Enter the message to be sent.");
        this.MessageText.WordWrap = false;
        this.BorderPanel.Controls.Add(this.ContainerPanel);
        this.BorderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.BorderPanel.Location = new System.Drawing.Point(0, 0);
        this.BorderPanel.Name = "BorderPanel";
        this.BorderPanel.Padding = new System.Windows.Forms.Padding(5);
        this.BorderPanel.Size = new System.Drawing.Size(645, 639);
        this.BorderPanel.TabIndex = 2;
        this.BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        this.ContainerPanel.Controls.Add(this.ContentPanel);
        this.ContainerPanel.Controls.Add(this.ButtonBar);
        this.ContainerPanel.Controls.Add(this.Header);
        this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ContainerPanel.Location = new System.Drawing.Point(5, 5);
        this.ContainerPanel.Name = "ContainerPanel";
        this.ContainerPanel.Size = new System.Drawing.Size(635, 629);
        this.ContainerPanel.TabIndex = 1;
        this.ContainerPanel.TemplateFile = null;
        this.ContentPanel.Controls.Add(this.FileButton);
        this.ContentPanel.Controls.Add(this.PrepareButton);
        this.ContentPanel.Controls.Add(this.MessageText);
        this.ContentPanel.Controls.Add(this.MessageHeader);
        this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ContentPanel.Location = new System.Drawing.Point(0, 60);
        this.ContentPanel.Name = "ContentPanel";
        this.ContentPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
        this.ContentPanel.Size = new System.Drawing.Size(635, 529);
        this.ContentPanel.TabIndex = 1;
        this.ContentPanel.TemplateFile = null;
        this.PrepareButton.Checked = false;
        this.PrepareButton.Location = new System.Drawing.Point(479, 489);
        this.PrepareButton.Name = "PrepareButton";
        this.PrepareButton.Size = new System.Drawing.Size(151, 32);
        this.PrepareButton.TabIndex = 3;
        this.PrepareButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
        this.PrepareButton.Text = "&Decode Message";
        this.ttp.SetToolTip(this.PrepareButton, "Click to decrypt the message for reading.");
        this.PrepareButton.UseVisualStyleBackColor = true;
        this.MessageHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.MessageHeader.Location = new System.Drawing.Point(5, 0);
        this.MessageHeader.Margin = new System.Windows.Forms.Padding(48, 23, 48, 23);
        this.MessageHeader.Name = "MessageHeader";
        this.MessageHeader.Size = new System.Drawing.Size(625, 25);
        this.MessageHeader.TabIndex = 0;
        this.MessageHeader.TabStop = false;
        this.MessageHeader.Text = "Message";
        this.ButtonBar.CancelEnabled = true;
        this.ButtonBar.CancelText = "Close";
        this.ButtonBar.CancelVisible = true;
        this.ButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.ButtonBar.Font = new System.Drawing.Font("Segoe UI", 9.75f);
        this.ButtonBar.Location = new System.Drawing.Point(0, 589);
        this.ButtonBar.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
        this.ButtonBar.Name = "ButtonBar";
        this.ButtonBar.SaveEnabled = true;
        this.ButtonBar.SaveText = "Copy";
        this.ButtonBar.SaveVisible = false;
        this.ButtonBar.Size = new System.Drawing.Size(635, 40);
        this.ButtonBar.TabIndex = 2;
        this.ttp.SetToolTip(this.ButtonBar, "Copy the encrypted content to the clipboard, or click Close to cancel the operation.");
        this.Header.Dock = System.Windows.Forms.DockStyle.Top;
        this.Header.Location = new System.Drawing.Point(0, 0);
        this.Header.Name = "Header";
        this.Header.Size = new System.Drawing.Size(635, 60);
        this.Header.TabIndex = 0;
        this.Header.TitleText = "ADAPTIVE DATA VAULT";
        this.FileButton.Checked = false;
        this.FileButton.Location = new System.Drawing.Point(479, 451);
        this.FileButton.Name = "FileButton";
        this.FileButton.Size = new System.Drawing.Size(151, 32);
        this.FileButton.TabIndex = 2;
        this.FileButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
        this.FileButton.Text = "&From File";
        this.ttp.SetToolTip(this.FileButton, "Click to load the encrypted text from a file.");
        this.FileButton.UseVisualStyleBackColor = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(645, 639);
        base.ControlBox = false;
        base.Controls.Add(this.BorderPanel);
        base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        base.Name = "DecodeSecureMessageDialog";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.BorderPanel.ResumeLayout(false);
        this.ContainerPanel.ResumeLayout(false);
        this.ContentPanel.ResumeLayout(false);
        this.ContentPanel.PerformLayout();
        base.ResumeLayout(false);
    }

    private TextBox MessageText;
    private ToolTip ttp;
    private GradientPanel BorderPanel;
    private GradientPanel ContainerPanel;
    private GradientPanel ContentPanel;
    private TemplatedButton PrepareButton;
    private SectionTitleHeader MessageHeader;
    private SaveCancelBar ButtonBar;
    private VaultDialogHeader Header;
    private TemplatedButton FileButton;

    #endregion
}