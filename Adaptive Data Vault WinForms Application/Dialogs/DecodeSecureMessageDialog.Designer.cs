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
        MessageText = new TextBox();
        BorderPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContainerPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        ContentPanel = new Adaptive.Intelligence.Shared.UI.GradientPanel();
        PrepareButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
        MessageHeader = new Adaptive.Intelligence.Shared.UI.SectionTitleHeader();
        ButtonBar = new Adaptive.Data.Vault.UI.Controls.SaveCancelBar();
        Header = new Adaptive.Data.Vault.UI.Controls.VaultDialogHeader();
        ttp = new ToolTip(components);
        FileButton = new Adaptive.Intelligence.Shared.UI.TemplatedButton();
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
        ContentPanel.TemplateFile = null;
        // 
        // PrepareButton
        // 
        PrepareButton.Checked = false;
        PrepareButton.Location = new Point(479, 489);
        PrepareButton.Name = "PrepareButton";
        PrepareButton.Size = new Size(151, 32);
        PrepareButton.TabIndex = 3;
        PrepareButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
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
        // FileButton
        // 
        FileButton.Checked = false;
        FileButton.Location = new Point(479, 451);
        FileButton.Name = "FileButton";
        FileButton.Size = new Size(151, 32);
        FileButton.TabIndex = 2;
        FileButton.TemplateFile = "D:\\Adaptive.Intelligence\\Win32\\Adaptive Data Vault\\Adaptive-Data-Vault\\Resources\\ADV Button.template";
        FileButton.Text = "&From File";
        ttp.SetToolTip(FileButton, "Click to load the encrypted text from a file.");
        FileButton.UseVisualStyleBackColor = true;
        // 
        // DecodeSecureMessageDialog
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(645, 639);
        ControlBox = false;
        Controls.Add(BorderPanel);
        FormBorderStyle = FormBorderStyle.None;
        Name = "DecodeSecureMessageDialog";
        StartPosition = FormStartPosition.CenterScreen;
        BorderPanel.ResumeLayout(false);
        ContainerPanel.ResumeLayout(false);
        ContentPanel.ResumeLayout(false);
        ContentPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TextBox MessageText;
    private ToolTip ttp;
    private Intelligence.Shared.UI.GradientPanel BorderPanel;
    private Intelligence.Shared.UI.GradientPanel ContainerPanel;
    private Intelligence.Shared.UI.GradientPanel ContentPanel;
    private Intelligence.Shared.UI.TemplatedButton PrepareButton;
    private Intelligence.Shared.UI.SectionTitleHeader MessageHeader;
    private Controls.SaveCancelBar ButtonBar;
    private Controls.VaultDialogHeader Header;
    private Intelligence.Shared.UI.TemplatedButton FileButton;
}