namespace Lab12
{
    public partial class MainForm : Form
    {

        Dictionary<int, string> certs = [];
        public MainForm()
        {
            InitializeComponent();

            certs.Add(0, "Сертифікат на будинок");
            certs.Add(1, "Сертифікат на навчання");

            certTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            certTypeComboBox.Items.Add(certs[0]);
            certTypeComboBox.Items.Add(certs[1]);
            certTypeComboBox.SelectedIndex = 0;
        }

        private void btnChooseCertType_Click(object sender, EventArgs e)
        {
            int certTypeIdx = certTypeComboBox.SelectedIndex;

            Form? certForm;
            switch (certTypeIdx)
            {
                case 0:
                    certForm = new HouseTmplForm(); 
                    break;
                case 1:
                    certForm = new EduTmplForm();
                    break;
                default:
                    certForm = null;
                    MessageBox.Show("Невідомий сертифікат обрано");
                    break;
            }
            certForm?.ShowDialog();
        }
    }
}
