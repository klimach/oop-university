namespace Lab2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Organization org1 = new Organization("SoftServe", new()
            {
                Country = "Ukraine",
                City = "Lviv",
                State = "Lviv Oblast",
                Zip = "79000",
                Street = "Stryiska Street",
                Building = "22"
            });

            Organization org2 = new Organization("Allgeier SE", new()
            {
                Country = "Germany",
                City = "Munich",
                State = "Bavaria",
                Zip = "80339",
                Street = "Einsteinstrasse",
                Building = "172"
            });

            Organization org3 = new Organization("Microsoft Corporation", new()
            {
                Country = "United States",
                City = "Redmond",
                State = "Washington",
                Zip = "98052",
                Street = "Microsoft Way",
                Building = "1"
            });

            orgList_listBox.Items.AddRange([org1, org2, org3]);
        }

        private void OrgName_textBox_TextChanged(object sender, EventArgs e) =>
            addOrg_button.Enabled = !string.IsNullOrWhiteSpace(orgName_textBox.Text);
        private void AddOrg_button_Click(object sender, EventArgs e) =>
            orgList_listBox.Items.Add(new Organization(orgName_textBox.Text.Trim()));
        private void OrgList_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            countryOrgAddress_textBox.Text = string.Empty;
            cityOrgAddress_textBox.Text = string.Empty;
            stateOrgAddress_textBox.Text = string.Empty;
            zipOrgAddress_textBox.Text = string.Empty;
            streetOrgAddress_textBox.Text = string.Empty;
            buildingOrgAddress_textBox.Text = string.Empty;

            if (orgList_listBox.SelectedItem is null)
            {
                removeOrg_button.Enabled = false;
                displayOrgAddress_richTextBox.Text = "Select organization from list";
                countryOrgAddress_textBox.Enabled = false;
                return;
            }

            Organization org = (Organization)orgList_listBox.SelectedItem;
            removeOrg_button.Enabled = true;
            countryOrgAddress_textBox.Enabled = true;

            displayOrgAddress_richTextBox.Text = org.GetPostalAddress();
            if (org.PostalAddress is not null)
            {
                countryOrgAddress_textBox.Text = org.PostalAddress.Country;
                cityOrgAddress_textBox.Text = org.PostalAddress.City;
                stateOrgAddress_textBox.Text = org.PostalAddress.State;
                zipOrgAddress_textBox.Text = org.PostalAddress.Zip;
                streetOrgAddress_textBox.Text = org.PostalAddress.Street;
                buildingOrgAddress_textBox.Text = org.PostalAddress.Building;
            }
        }

        private void RemoveOrg_button_Click(object sender, EventArgs e)
        {
            if (orgList_listBox.SelectedItem is null) return;
            orgList_listBox.Items.Remove(orgList_listBox.SelectedItem);
        }

        private void SaveOrgAddress_button_Click(object sender, EventArgs e)
        {
            OrganizationPostalAddress organizationPostalAddress = new()
            {
                Country = countryOrgAddress_textBox.Text,
                City = cityOrgAddress_textBox.Text,
                State = stateOrgAddress_textBox.Text,
                Zip = zipOrgAddress_textBox.Text,
                Street = streetOrgAddress_textBox.Text,
                Building = buildingOrgAddress_textBox.Text
            };

            ((Organization)orgList_listBox.SelectedItem!).PostalAddress = organizationPostalAddress;
            displayOrgAddress_richTextBox.Text = organizationPostalAddress.GetAddressForDisplay();
        }

        private void CountryOrgAddress_textBox_TextChanged(object sender, EventArgs e)
        {
            bool isFilled = !string.IsNullOrWhiteSpace(countryOrgAddress_textBox.Text);
            cityOrgAddress_textBox.Enabled = isFilled;
            stateOrgAddress_textBox.Enabled = isFilled;
        }

        private void CityStateOrgAddress_textBox_TextChanged(object sender, EventArgs e)
        {
            bool isFilled =
                !string.IsNullOrWhiteSpace(cityOrgAddress_textBox.Text) && !string.IsNullOrWhiteSpace(stateOrgAddress_textBox.Text);
            zipOrgAddress_textBox.Enabled = isFilled;
            streetOrgAddress_textBox.Enabled = isFilled;
        }

        private void StreetOrgAddress_textBox_TextChanged(object sender, EventArgs e)
        {
            bool isFilled = !string.IsNullOrWhiteSpace(streetOrgAddress_textBox.Text);
            buildingOrgAddress_textBox.Enabled = isFilled;
        }

        private void BuildingOrgAddress_textBox_TextChanged(object sender, EventArgs e)
        {
            bool isFilled = !string.IsNullOrWhiteSpace(buildingOrgAddress_textBox.Text);
            saveOrgAddress_button.Enabled = isFilled;
        }
    }
}
