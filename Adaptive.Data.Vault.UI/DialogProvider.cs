namespace Adaptive.Data.Vault.UI
{
    /// <summary>
    /// Provides static methods and functions for displaying common dialogs.
    /// </summary>
    public static class DialogProvider
    {
        /// <summary>
        /// Creates the open file dialog instance to prompt the user to open a file.
        /// </summary>
        /// <returns>
        /// An <see cref="OpenFileDialog"/> instance.
        /// </returns>
        public static OpenFileDialog CreateOpenFileDialog(string? fileName = null)
        {
            // Select the file to open.
            OpenFileDialog dialog = new OpenFileDialog
            {
                AddExtension = true,
                AddToRecent = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = FileConstants.ExtensionSecureFile,
                Filter = FileConstants.FilterSecureAndClearFile,
                SupportMultiDottedExtensions = true,
                Title = Properties.Resources.DialogTitleOpen
            };
            if (!string.IsNullOrEmpty(fileName))
            {
                dialog.FileName = fileName;
            }
            return dialog;
        }
        /// <summary>
        /// Creates the save file dialog instance to prompt the user to create or save a file.
        /// </summary>
        /// <returns>
        /// A <see cref="SaveFileDialog"/> instance.
        /// </returns>
        public static SaveFileDialog CreateSaveFileDialog(string? originalFileName = null)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                AddExtension = true,
                AddToRecent = true,
                AutoUpgradeEnabled = true,
                CheckWriteAccess = true,
                OverwritePrompt = true,
                DefaultExt = FileConstants.ExtensionSecureFile,
                Filter = FileConstants.FilterSecureFile,
                SupportMultiDottedExtensions = true,
                Title = Properties.Resources.DialogTitleSaveAs
            };

            if (!string.IsNullOrEmpty(originalFileName))
            {
                dialog.FileName = originalFileName;
            }
            return dialog;
        }

        /// <summary>
        /// Prompts the user to login to a file after one is selected.
        /// </summary>
        /// <param name="selectedFile">
        /// A string containing the fully-qualified path and name of the file, or 
        /// <b>null</b> if credentials are being entered to create a new file.
        /// </param>
        /// <returns>
        /// A <see cref="SecureFileParameters"/> instance containing the user-entered data,
        /// or <b>null</b> if the user cancels.
        /// </returns>
        public static SecureFileParameters? DisplayLoginDialog(string? selectedFile)
        {
            SecureFileParameters? fileParams = null;

            LoginDialog dialog = new LoginDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileParams = new SecureFileParameters
                {
                    FileName = selectedFile,
                    UserId = dialog.UserId,
                    Password = dialog.Password,
                    Pin = dialog.Pin
                };
            }
            dialog.Dispose();

            return fileParams;
        }

        /// <summary>
        /// Creates the add or edit category dialog.
        /// </summary>
        /// <param name="category">
        /// The <see cref="UserCategory"/> instance to edit, or 
        /// <b>null</b> to create a new instance.
        /// </param>
        /// <returns>
        /// The <see cref="AddEditCategoryDialog"/> instance to be displayed.
        /// </returns>
        public static AddEditCategoryDialog CreateEditCategoryDialog(UserCategory? category)
        {
            if (category == null)
                return new AddEditCategoryDialog();
            else
                return new AddEditCategoryDialog(category);
        }


        /// <summary>
        /// Creates the add or edit identity provider dialog.
        /// </summary>
        /// <param name="category">
        /// The <see cref="IdentityProvider"/> instance to edit, or 
        /// <b>null</b> to create a new instance.
        /// </param>
        /// <returns>
        /// The <see cref="AddEditIdentityProviderDialog"/> instance to be displayed.
        /// </returns>
        public static AddEditIdentityProviderDialog CreateEditIdProviderDialog(IdentityProvider? provider)
        {
            if (provider == null)
                return new AddEditIdentityProviderDialog();
            else
                return new AddEditIdentityProviderDialog(provider);
        }

        /// <summary>
        /// Creates the add or edit secure note dialog.
        /// </summary>
        /// <param name="category">
        /// The <see cref="SecureNote"/> instance to edit, or 
        /// <b>null</b> to create a new instance.
        /// </param>
        /// <returns>
        /// The <see cref="AddEditSecureNoteDialog"/> instance to be displayed.
        /// </returns>
        public static AddEditSecureNoteDialog CreateEditSecureNoteDialog(SecureNote? note)
        {
            if (note == null)
                return new AddEditSecureNoteDialog();
            else
                return new AddEditSecureNoteDialog(note);
        }

        /// <summary>
        /// Creates the add or edit web account dialog.
        /// </summary>
        /// <param name="category">
        /// The <see cref="WebAccount"/> instance to edit, or 
        /// <b>null</b> to create a new instance.
        /// </param>
        /// <returns>
        /// The <see cref="AddEditWebAccountDialog"/> instance to be displayed.
        /// </returns>
        public static AddEditWebAccountDialog CreateEditWebAccountDialog(WebAccount? account)
        {
            if (account == null)
                return new AddEditWebAccountDialog();
            else
                return new AddEditWebAccountDialog(account);
        }
    }
}
