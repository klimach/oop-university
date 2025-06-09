using RGR.Models;

namespace RGR.Helpers
{
    public static class Helpers
    {
        public static Dictionary<string, string> GetMappingDict(Person person)
        {

            var today = DateTime.Today;

            return new Dictionary<string, string>
            {
                { "secondName", person.SecondName },
                { "firstName", person.FirstName },
                { "middleName", person.MiddleName ?? "-" },
                { "gender", person.Gender },
                { "birthDate", person.BirthDate },
                { "address", person.Address },
                { "phone", person.Phone },
                { "email", person.Email },
                { "passportNumber", person.PassportNumber ?? "-" },
                { "passportIssueDate", person.PassportIssueDate ?? "-" },
                { "passportIssuedBy", person.PassportIssuedBy ?? "-" },
                { "jobTitle", person.JobTitle ?? "-" },
                { "organization", person.Organization ?? "-" },
                { "fullNameOriginal", person.FullName },
                { "currentDate", today.ToString("dd.MM.yyyy") },
                { "day", today.ToString("dd") },
                { "month", today.ToString("MMMM") },
                { "year", today.ToString("yyyy") },
                { "fullNameGenitive", GetFullNameGenetive(person, GrammaticalCase.Genitive) },
                { "fullNameDative", GetFullNameGenetive(person, GrammaticalCase.Dative) }
            };
        }

        private static string GetFullNameGenetive(Person person, GrammaticalCase gramCase)
        {
            Gender gender = person.Gender.ToLower().Equals("він") ? Gender.Male : Gender.Female;

            string secondNameGen = UaNameDecliner.Decline(person.SecondName, gender, gramCase);
            string firstNameGen = UaNameDecliner.Decline(person.FirstName, gender, gramCase);
            string middleNameGen = string.Empty;
            if (!string.IsNullOrEmpty(person.MiddleName))
            {
                middleNameGen = UaNameDecliner.Decline(person.MiddleName ?? "", gender, gramCase);
            }

            return string.Join(" ", new[] { secondNameGen, firstNameGen, middleNameGen }
                .Where(s => !string.IsNullOrWhiteSpace(s)));
        }
    }
}
