using Adaptive.Intelligence.Shared.UI;

namespace Adaptive.Data.Vault.UI;

partial class CategorizedItemsContainerControl
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
        TabsPanel = new Panel();
        SecureNotesButton = new TemplatedButton();
        IdSeparatorPanel = new Panel();
        IdProvidersButton = new TemplatedButton();
        AcctSeparatorPanel = new Panel();
        AccountsButton = new TemplatedButton();
        WebAccountsList = new WebAccountListControl();
        IdProvidersList = new IdentityProviderListControl();
        SecureNotesList = new SecureNoteListControl();
        TabsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // TabsPanel
        // 
        TabsPanel.Controls.Add(SecureNotesButton);
        TabsPanel.Controls.Add(IdSeparatorPanel);
        TabsPanel.Controls.Add(IdProvidersButton);
        TabsPanel.Controls.Add(AcctSeparatorPanel);
        TabsPanel.Controls.Add(AccountsButton);
        TabsPanel.Dock = DockStyle.Top;
        TabsPanel.Location = new Point(0, 0);
        TabsPanel.Name = "TabsPanel";
        TabsPanel.Padding = new Padding(0, 0, 5, 5);
        TabsPanel.Size = new Size(800, 69);
        TabsPanel.TabIndex = 0;
        // 
        // SecureNotesButton
        // 
        SecureNotesButton.Checked = false;
        SecureNotesButton.Dock = DockStyle.Left;
        SecureNotesButton.Location = new Point(410, 0);
        SecureNotesButton.Name = "SecureNotesButton";
        SecureNotesButton.Size = new Size(200, 64);
        SecureNotesButton.TabIndex = 2;
        SecureNotesButton.TemplateSource = Properties.Resources.ButtonTemplateStandard;
        SecureNotesButton.Text = "Secure Notes";
        SecureNotesButton.UseVisualStyleBackColor = true;
        // 
        // IdSeparatorPanel
        // 
        IdSeparatorPanel.Dock = DockStyle.Left;
        IdSeparatorPanel.Location = new Point(405, 0);
        IdSeparatorPanel.Name = "IdSeparatorPanel";
        IdSeparatorPanel.Size = new Size(5, 64);
        IdSeparatorPanel.TabIndex = 4;
        // 
        // IdProvidersButton
        // 
        IdProvidersButton.Checked = false;
        IdProvidersButton.Dock = DockStyle.Left;
        IdProvidersButton.Location = new Point(205, 0);
        IdProvidersButton.Margin = new Padding(5, 3, 3, 3);
        IdProvidersButton.Name = "IdProvidersButton";
        IdProvidersButton.Size = new Size(200, 64);
        IdProvidersButton.TabIndex = 1;
        IdProvidersButton.TemplateFile = null;
        IdProvidersButton.TemplateSource = Properties.Resources.ButtonTemplateStandard;
        IdProvidersButton.Text = "Identity Providers";
        IdProvidersButton.UseVisualStyleBackColor = true;
        // 
        // AcctSeparatorPanel
        // 
        AcctSeparatorPanel.Dock = DockStyle.Left;
        AcctSeparatorPanel.Location = new Point(200, 0);
        AcctSeparatorPanel.Name = "AcctSeparatorPanel";
        AcctSeparatorPanel.Size = new Size(5, 64);
        AcctSeparatorPanel.TabIndex = 3;
        // 
        // AccountsButton
        // 
        AccountsButton.Checked = true;
        AccountsButton.Dock = DockStyle.Left;
        AccountsButton.Location = new Point(0, 0);
        AccountsButton.Name = "AccountsButton";
        AccountsButton.Size = new Size(200, 64);
        AccountsButton.TabIndex = 0;
        AccountsButton.TemplateFile = null;
        AccountsButton.TemplateSource = Properties.Resources.ButtonTemplateStandard;
        AccountsButton.Text = "Accounts";
        AccountsButton.UseVisualStyleBackColor = true;
        // 
        // WebAccountsList
        // 
        WebAccountsList.AutoScroll = true;
        WebAccountsList.BackColor = Color.White;
        WebAccountsList.Dock = DockStyle.Fill;
        WebAccountsList.Font = new Font("Segoe UI", 9.75F);
        WebAccountsList.Location = new Point(0, 69);
        WebAccountsList.Name = "WebAccountsList";
        WebAccountsList.Size = new Size(800, 531);
        WebAccountsList.TabIndex = 1;
        WebAccountsList.Visible = false;
        // 
        // IdProvidersList
        // 
        IdProvidersList.BackColor = Color.White;
        IdProvidersList.Dock = DockStyle.Fill;
        IdProvidersList.Location = new Point(0, 69);
        IdProvidersList.Name = "IdProvidersList";
        IdProvidersList.Size = new Size(800, 531);
        IdProvidersList.TabIndex = 2;
        IdProvidersList.Visible = false;
        // 
        // SecureNotesList
        // 
        SecureNotesList.BackColor = Color.White;
        SecureNotesList.Dock = DockStyle.Fill;
        SecureNotesList.Location = new Point(0, 69);
        SecureNotesList.Name = "SecureNotesList";
        SecureNotesList.Size = new Size(800, 531);
        SecureNotesList.TabIndex = 3;
        SecureNotesList.Visible = false;
        // 
        // CategorizedItemsContainerControl
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        Controls.Add(SecureNotesList);
        Controls.Add(IdProvidersList);
        Controls.Add(WebAccountsList);
        Controls.Add(TabsPanel);
        Margin = new Padding(3);
        Name = "CategorizedItemsContainerControl";
        Size = new Size(800, 600);
        TabsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel TabsPanel;
    private Intelligence.Shared.UI.TemplatedButton SecureNotesButton;
    private Intelligence.Shared.UI.TemplatedButton IdProvidersButton;
    private Intelligence.Shared.UI.TemplatedButton AccountsButton;
    private Panel IdSeparatorPanel;
    private Panel AcctSeparatorPanel;
    private WebAccountListControl WebAccountsList;
    private IdentityProviderListControl IdProvidersList;
    private SecureNoteListControl SecureNotesList;
}
