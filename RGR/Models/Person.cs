namespace RGR.Models
{
    public class Person
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string SecondName { get; set; }
        public string? MiddleName { get; set; }
        public required string Gender { get; set; }
        public required string BirthDate { get; set; }
        public required string Address { get; set; }
        public required string Phone { get; set; }
        public required string Email { get; set; }
        public string? PassportNumber { get; set; }
        public string? PassportIssueDate { get; set; }
        public string? PassportIssuedBy { get; set; }
        public string? JobTitle { get; set; }
        public string? Organization { get; set; }

        public bool IsAdult
        {
            get
            {
                if (DateTime.TryParse(BirthDate, out DateTime birthDate))
                {
                    int age = DateTime.Today.Year - birthDate.Year;
                    if (birthDate > DateTime.Today.AddYears(-age)) age--;
                    return age >= 18;
                }
                return false;
            }
        }

        public bool IsPassportEligible
        {
            get
            {
                if (DateTime.TryParse(BirthDate, out DateTime birthDate))
                {
                    int age = DateTime.Today.Year - birthDate.Year;
                    if (birthDate > DateTime.Today.AddYears(-age)) age--;
                    return age >= 14;
                }
                return false;
            }
        }

        public string FullName => string.Join(" ", new[] { SecondName, FirstName, MiddleName }
            .Where(s => !string.IsNullOrWhiteSpace(s)));

        public string ShortName
        {
            get
            {
                string firstInitial = !string.IsNullOrWhiteSpace(FirstName) ? FirstName[0] + "." : "";
                string middleInitial = !string.IsNullOrWhiteSpace(MiddleName) ? MiddleName[0] + "." : "";

                return string.Join(" ", new[] { SecondName, firstInitial, middleInitial }
                    .Where(s => !string.IsNullOrWhiteSpace(s)));
            }
        }

        public string JobFullInfo =>
            string.IsNullOrWhiteSpace(JobTitle) && string.IsNullOrWhiteSpace(Organization)
                ? "—"
                : $"{JobTitle} в {Organization}";

        public string PassportFullInfo =>
            string.IsNullOrWhiteSpace(PassportNumber) ? "—" :
                $"{PassportNumber}, виданий {PassportIssueDate}, {PassportIssuedBy}";
    }
}