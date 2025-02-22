using System.Data;
using System.Diagnostics;
using System.Text;

namespace Lab2Project
{
    public class Organization : IDisposable
    {
        private string name = string.Empty;
        private OrganizationPostalAddress? postalAddress = null;

        public string Name
        {
            get { return name; }
            set { if (!string.IsNullOrWhiteSpace(value)) name = value; }
        }
        public OrganizationPostalAddress? PostalAddress
        {
            get { return postalAddress; }
            set { if (value is not null) postalAddress = value; }
        }

        public Organization() { }
        public void Dispose()
        {
            PostalAddress?.Dispose();
            GC.SuppressFinalize(this);
        }
        public Organization(string organizationName)
        {
            name = organizationName;
        }
        public Organization(string organizationName, OrganizationPostalAddress postalAddress)
        {
            name = organizationName;
            this.postalAddress = postalAddress;
        }

        public string GetPostalAddress()
        {
            return postalAddress?.GetAddressForDisplay() ?? "No address";
        }

        public override string ToString()
        {
            return name;
        }
    }
    public class OrganizationPostalAddress : IDisposable
    {
        ///////////// Attributes //////////////
        private string country = string.Empty;
        private string city = string.Empty;
        private string state = string.Empty;
        private string zip = string.Empty;
        private string street = string.Empty;
        private string building = string.Empty;

        ///////////// Getters/Setters //////////////
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Building
        {
            get { return building; }
            set { building = value; }
        }

        ///////////// Constructors //////////////
        public OrganizationPostalAddress() { }
        public OrganizationPostalAddress(string country, string city, string state, string zip, string street, string building)
        {
            this.country = country;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.street = street;
            this.building = building;
        }
        public OrganizationPostalAddress(OrganizationPostalAddress organizationPostalAddress)
        {
            country = organizationPostalAddress.Country;
            city = organizationPostalAddress.City;
            state = organizationPostalAddress.State;
            zip = organizationPostalAddress.Zip;
            street = organizationPostalAddress.Street;
            building = organizationPostalAddress.Building;
        }

        public void Dispose()
        {
            Trace.WriteLine("OrganizationPostalAddress object disposed.");
            GC.SuppressFinalize(this);
        }

        ///////////// Static method //////////////
        public static OrganizationPostalAddress Copy(OrganizationPostalAddress organizationPostalAddress)
        {
            return new OrganizationPostalAddress(organizationPostalAddress);
        }

        ///////////// Non-Static methods //////////////
        public string GetAddressForDisplay()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine($"Country: {country}");
            stringBuilder.AppendLine($"City: {city}");
            stringBuilder.AppendLine($"State: {state}");
            stringBuilder.AppendLine($"Address: {street} {building}");
            stringBuilder.AppendLine($"Zip: {zip}");
            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendJoin(", ",
                new string[] { country, city, state, $"{street} {building}", zip }
                    .Where(el => !string.IsNullOrWhiteSpace(el))
                    .Select(el => el.Trim()));
            return stringBuilder.ToString();
        }
    }
}
