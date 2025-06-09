using System;
using System.IO;
using System.Windows.Forms;

namespace Lab14
{
    public partial class EditAttributesForm : Form
    {
        public FileAttributes SelectedAttributes { get; private set; }

        public EditAttributesForm(FileAttributes currentAttributes)
        {
            InitializeComponent();

            chkHidden.Checked = currentAttributes.HasFlag(FileAttributes.Hidden);
            chkReadOnly.Checked = currentAttributes.HasFlag(FileAttributes.ReadOnly);
            chkArchive.Checked = currentAttributes.HasFlag(FileAttributes.Archive);
            chkSystem.Checked = currentAttributes.HasFlag(FileAttributes.System);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedAttributes = 0;

            if (chkHidden.Checked) SelectedAttributes |= FileAttributes.Hidden;
            if (chkReadOnly.Checked) SelectedAttributes |= FileAttributes.ReadOnly;
            if (chkArchive.Checked) SelectedAttributes |= FileAttributes.Archive;
            if (chkSystem.Checked) SelectedAttributes |= FileAttributes.System;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}