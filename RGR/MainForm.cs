using RGR.Controllers;
using RGR.Models;
using RGR.Providers;
using System.ComponentModel;

namespace RGR
{
    public partial class MainForm : Form
    {
        private readonly DBController _dbController;
        //private IWordProvider _wordProvider;

        private bool isAllSelected = false;
        public MainForm()
        {
            InitializeComponent();
            _dbController = new DBController("persons.db");
            //_wordProvider = new InteropWordProvider();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //listViewPeople.Columns.Clear();
            lvPeople.Columns.Add("ФІО", 200);
            lvPeople.Columns.Add("Дата народження", 100);
            lvPeople.Columns.Add("Email", 150);
            lvPeople.Columns.Add("Телефон", 100);
            lvPeople.Columns.Add("Адреса", 200);

            ReloadPeopleList();

            clbTemplates.Items.Add("Візитівки");
            clbTemplates.Items.Add("Подяка");
            clbTemplates.Items.Add("Анекта співробітника");
            clbTemplates.Items.Add("Довідка з місця роботи");
            clbTemplates.Items.Add("Наказ на звільнення");
        }

        private void ReloadPeopleList()
        {
            lvPeople.Items.Clear();

            List<Person> people = _dbController.GetAllPeople();

            foreach (var person in people)
            {
                var item = new ListViewItem(person.FullName);
                item.SubItems.Add(person.BirthDate);
                item.SubItems.Add(person.Email);
                item.SubItems.Add(person.Phone);
                item.SubItems.Add(person.Address);

                item.Tag = person;

                lvPeople.Items.Add(item);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            isAllSelected = !isAllSelected;
            foreach (ListViewItem item in lvPeople.Items)
                item.Checked = isAllSelected;
            btnSelectAll.Text = isAllSelected ? "Зняти всі" : "Обрати всі";
        }

        private void cmsLVPeople_Opening(object sender, CancelEventArgs e)
        {
            Point mousePos = lvPeople.PointToClient(Cursor.Position);
            ListViewItem? item = lvPeople.GetItemAt(mousePos.X, mousePos.Y);
            bool isItemSelected = item != null;
            cmsLVPeople.Items[0].Enabled = isItemSelected;
            cmsLVPeople.Items[1].Enabled = isItemSelected;

            Person? person = isItemSelected && item?.Tag is Person p ? p : null;

            cmsLVPeople.Items[0].Tag = person;
            cmsLVPeople.Items[1].Tag = person;
        }

        private void rowDetails_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is Person person)
            {
                PersonDetailsForm pdForm = new(_dbController, person);
                pdForm.ShowDialog();
                if (pdForm.IsUpdated)
                {
                    ReloadPeopleList();
                }
                return;
            }

            if (sender is Button && lvPeople.SelectedItems[0].Tag is Person person2)
            {
                PersonDetailsForm pdForm = new(_dbController, person2);
                pdForm.ShowDialog();
                if (pdForm.IsUpdated)
                {
                    ReloadPeopleList();
                }
                return;
            }
        }

        private void rowRemove_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.Tag is Person person)
            {
                _dbController.DeletePerson(person.Id);
                ReloadPeopleList();
                MessageBox.Show($"Запис успішно видалено");
                return;
            }

            if (sender is Button && lvPeople.SelectedItems[0].Tag is Person person2)
            {
                _dbController.DeletePerson(person2.Id);
                ReloadPeopleList();
                MessageBox.Show($"Запис успішно видалено");
                return;
            }
        }

        private void rowAddNew_Click(object sender, EventArgs e)
        {
            PersonDetailsForm pdForm = new(_dbController);
            pdForm.ShowDialog();
            if (pdForm.IsUpdated)
            {
                ReloadPeopleList();
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                tbOutputFolder.Text = dialog.SelectedPath;
            }
        }

        private void cbWordProvider_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is CheckBox changedBox)
            {

                if (!changedBox.Checked)
                {
                    changedBox.Checked = true;
                    return;
                }

                //OpenXml провайдер потребує доопрацювання 

                //if (changedBox.Checked)
                //{
                //    if (changedBox == cbInterop && cbOpenXml.Checked)
                //        cbOpenXml.Checked = false;
                //    else if (changedBox == cbOpenXml && cbInterop.Checked)
                //        cbInterop.Checked = false;
                //}
                //else
                //{
                //    if (!cbInterop.Checked && !cbOpenXml.Checked)
                //    {
                //        if (changedBox == cbInterop)
                //            cbOpenXml.Checked = true;
                //        else
                //            cbInterop.Checked = true;
                //    }
                //}

                //_wordProvider = cbInterop.Checked ?
                //    new InteropWordProvider() : new OpenXmlWordProvider();
            }
        }

        private void btnGenerateDocs_Click(object sender, EventArgs e)
        {
            if (lvPeople.CheckedItems.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть хоча б одну людину.", 
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbTemplates.CheckedItems.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть хоча б один шаблон документа.", 
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbOutputFolder.Text) || 
                !Directory.Exists(tbOutputFolder.Text))
            {
                MessageBox.Show("Будь ласка, виберіть коректну папку для збереження.", 
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using InteropWordProvider2 wordProvider = new();

            string templatesPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Templates");
            foreach (ListViewItem item in lvPeople.CheckedItems)
            {
                if (item.Tag is Person person)
                {
                    string personFolder = Path.Combine(tbOutputFolder.Text, 
                        $"{person.FullName} {person.BirthDate}");
                    if (!Directory.Exists(personFolder))
                    {
                        Directory.CreateDirectory(personFolder);
                    }
                    foreach (var template in clbTemplates.CheckedItems)
                    {
                        string templateFile = Path.Combine(
                            templatesPath, $"{template}.docx");
                        string outputFile = Path.Combine(personFolder, 
                            $"{template} - {person.ShortName}.docx");
                        wordProvider.GenerateDocumentFromTemplate(templateFile, 
                            outputFile, Helpers.Helpers.GetMappingDict(person));
                    }
                }
            }

            MessageBox.Show("Документи успішно згенеровано.", 
                "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDetails.Enabled = lvPeople.SelectedItems.Count > 0;
            btnRemove.Enabled = lvPeople.SelectedItems.Count > 0;
        }
    }
}
