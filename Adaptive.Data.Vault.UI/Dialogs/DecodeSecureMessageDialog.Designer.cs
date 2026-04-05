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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecodeSecureMessageDialog));
        MessageText = new TextBox();
        BorderPanel = new TemplatedGradientPanel();
        ContainerPanel = new TemplatedGradientPanel();
        ContentPanel = new TemplatedGradientPanel();
        FileButton = new TemplatedButton();
        PrepareButton = new TemplatedButton();
        MessageHeader = new SectionTitleHeader();
        ButtonBar = new SaveCancelBar();
        Header = new VaultDialogHeader();
        ttp = new ToolTip(components);
        BorderPanel.SuspendLayout();
        ContainerPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        SuspendLayout();
        // 
        // MessageText
        // 
        MessageText.AcceptsReturn = true;
        MessageText.AcceptsTab = true;
        MessageText.BackColor = Color.Black;
        MessageText.Dock = DockStyle.Top;
        MessageText.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MessageText.ForeColor = Color.DarkGreen;
        MessageText.Location = new Point(5, 25);
        MessageText.Multiline = true;
        MessageText.Name = "MessageText";
        MessageText.PlaceholderText = "(Enter Message Here or Paste the Text from the Clipboard.)";
        MessageText.Size = new Size(625, 420);
        MessageText.TabIndex = 1;
        ttp.SetToolTip(MessageText, "Enter the message to be sent.");
        MessageText.WordWrap = false;
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContainerPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(645, 639);
        BorderPanel.TabIndex = 2;
        BorderPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\Standard Panel.panel.template.json";
        BorderPanel.TemplateJson = resources.GetString("BorderPanel.TemplateJson");
        // 
        // ContainerPanel
        // 
        ContainerPanel.Controls.Add(ContentPanel);
        ContainerPanel.Controls.Add(ButtonBar);
        ContainerPanel.Controls.Add(Header);
        ContainerPanel.Dock = DockStyle.Fill;
        ContainerPanel.Location = new Point(5, 5);
        ContainerPanel.Name = "ContainerPanel";
        ContainerPanel.Size = new Size(635, 629);
        ContainerPanel.TabIndex = 1;
        ContainerPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\Standard Panel.json";
        ContainerPanel.TemplateJson = resources.GetString("ContainerPanel.TemplateJson");
        // 
        // ContentPanel
        // 
        ContentPanel.Controls.Add(FileButton);
        ContentPanel.Controls.Add(PrepareButton);
        ContentPanel.Controls.Add(MessageText);
        ContentPanel.Controls.Add(MessageHeader);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(0, 60);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Padding = new Padding(5, 0, 5, 5);
        ContentPanel.Size = new Size(635, 529);
        ContentPanel.TabIndex = 1;
        ContentPanel.TemplateFromFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\Button Templates\\General Background.panel.template.json";
        ContentPanel.TemplateJson = resources.GetString("ContentPanel.TemplateJson");
        // 
        // FileButton
        // 
        FileButton.Checked = false;
        FileButton.Location = new Point(479, 451);
        FileButton.Name = "FileButton";
        FileButton.Size = new Size(151, 32);
        FileButton.TabIndex = 2;
        FileButton.TemplateFromFile = null;
        FileButton.TemplateJson = resources.GetString("FileButton.TemplateJson");
        FileButton.Text = "&From File";
        ttp.SetToolTip(FileButton, "Click to load the encrypted text from a file.");
        FileButton.UseVisualStyleBackColor = true;
        // 
        // PrepareButton
        // 
        PrepareButton.Checked = false;
        PrepareButton.Location = new Point(479, 489);
        PrepareButton.Name = "PrepareButton";
        PrepareButton.Size = new Size(151, 32);
        PrepareButton.TabIndex = 3;
        PrepareButton.TemplateFromFile = null;
        PrepareButton.TemplateJson = resources.GetString("PrepareButton.TemplateJson");
        PrepareButton.Text = "&Decode Message";
        ttp.SetToolTip(PrepareButton, "Click to decrypt the message for reading.");
        PrepareButton.UseVisualStyleBackColor = true;
        // 
        // MessageHeader
        // 
        MessageHeader.Dock = DockStyle.Top;
        MessageHeader.Location = new Point(5, 0);
        MessageHeader.Margin = new Padding(48, 23, 48, 23);
        MessageHeader.Name = "MessageHeader";
        MessageHeader.Size = new Size(625, 25);
        MessageHeader.TabIndex = 0;
        MessageHeader.TabStop = false;
        MessageHeader.Text = "Message";
        // 
        // ButtonBar
        // 
        ButtonBar.CancelEnabled = true;
        ButtonBar.CancelText = "Close";
        ButtonBar.CancelVisible = true;
        ButtonBar.Dock = DockStyle.Bottom;
        ButtonBar.Font = new Font("Segoe UI", 9.75F);
        ButtonBar.Location = new Point(0, 589);
        ButtonBar.Margin = new Padding(48, 22, 48, 22);
        ButtonBar.Name = "ButtonBar";
        ButtonBar.SaveEnabled = true;
        ButtonBar.SaveText = "Copy";
        ButtonBar.SaveVisible = false;
        ButtonBar.Size = new Size(635, 40);
        ButtonBar.TabIndex = 2;
        ttp.SetToolTip(ButtonBar, "Copy the encrypted content to the clipboard, or click Close to cancel the operation.");
        // 
        // Header
        // 
        Header.Dock = DockStyle.Top;
        Header.Location = new Point(0, 0);
        Header.Name = "Header";
        Header.Size = new Size(635, 60);
        Header.TabIndex = 0;
        Header.TitleText = "ADAPTIVE DATA VAULT";
        // 
        // DecodeSecureMessageDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(645, 639);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "DecodeSecureMessageDialog";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ContentPanel.PerformLayout();
        ResumeLayout(false);
    }

    private TextBox MessageText;
    private ToolTip ttp;
    private TemplatedGradientPanel BorderPanel;
    private TemplatedGradientPanel ContainerPanel;
    private TemplatedGradientPanel ContentPanel;
    private TemplatedButton PrepareButton;
    private SectionTitleHeader MessageHeader;
    private SaveCancelBar ButtonBar;
    private VaultDialogHeader Header;
    private TemplatedButton FileButton;

    #endregion
}