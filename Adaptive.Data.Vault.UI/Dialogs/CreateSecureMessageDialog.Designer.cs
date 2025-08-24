using Adaptive.Data.Vault.UI.Controls;
using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class CreateSecureMessageDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        BorderPanel = new GradientPanel();
        ContainerPanel = new GradientPanel();
        ContentPanel = new GradientPanel();
        PrepareButton = new TemplatedButton();
        MessageText = new TextBox();
        MessageHeader = new SectionTitleHeader();
        ButtonBar = new SaveCancelBar();
        Header = new VaultDialogHeader();
        ttp = new ToolTip(components);
        BorderPanel.SuspendLayout();
        ContainerPanel.SuspendLayout();
        ContentPanel.SuspendLayout();
        SuspendLayout();
        // 
        // BorderPanel
        // 
        BorderPanel.Controls.Add(ContainerPanel);
        BorderPanel.Dock = DockStyle.Fill;
        BorderPanel.Location = new Point(0, 0);
        BorderPanel.Name = "BorderPanel";
        BorderPanel.Padding = new Padding(5);
        BorderPanel.Size = new Size(645, 639);
        BorderPanel.TabIndex = 1;
        BorderPanel.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
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
        ContainerPanel.TemplateFile = null;
        // 
        // ContentPanel
        // 
        ContentPanel.Controls.Add(PrepareButton);
        ContentPanel.Controls.Add(MessageText);
        ContentPanel.Controls.Add(MessageHeader);
        ContentPanel.Dock = DockStyle.Fill;
        ContentPanel.Location = new Point(0, 60);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Padding = new Padding(5, 0, 5, 5);
        ContentPanel.Size = new Size(635, 529);
        ContentPanel.TabIndex = 1;
        ContentPanel.TemplateFile = null;
        // 
        // PrepareButton
        // 
        PrepareButton.Checked = false;
        PrepareButton.Location = new Point(479, 489);
        PrepareButton.Name = "PrepareButton";
        PrepareButton.ResourceTemplate = null;
        PrepareButton.Size = new Size(151, 32);
        PrepareButton.TabIndex = 6;
        PrepareButton.ResourceTemplate = Properties.Resources.ButtonTemplateStandard;
        PrepareButton.Text = "&Prepare Message";
        ttp.SetToolTip(PrepareButton, "Click to prepare the message for sending,");
        PrepareButton.UseVisualStyleBackColor = true;
        // 
        // MessageText
        // 
        MessageText.BackColor = Color.Black;
        MessageText.Dock = DockStyle.Top;
        MessageText.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MessageText.ForeColor = Color.DarkGreen;
        MessageText.Location = new Point(5, 25);
        MessageText.Multiline = true;
        MessageText.Name = "MessageText";
        MessageText.PlaceholderText = "(Enter Message Here)";
        MessageText.Size = new Size(625, 458);
        MessageText.TabIndex = 1;
        ttp.SetToolTip(MessageText, "Enter the message to be sent.");
        MessageText.WordWrap = false;
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
        ButtonBar.SaveVisible = true;
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
        // CreateSecureMessageDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(645, 639);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        KeyPreview = true;
        Name = "CreateSecureMessageDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ContentPanel.PerformLayout();
        ResumeLayout(false);
    }

    private GradientPanel BorderPanel;
    private GradientPanel ContainerPanel;
    private SaveCancelBar ButtonBar;
    private VaultDialogHeader Header;
    private GradientPanel ContentPanel;
    private TextBox MessageText;
    private SectionTitleHeader MessageHeader;
    private ToolTip ttp;
    private TemplatedButton PrepareButton;

    #endregion
}