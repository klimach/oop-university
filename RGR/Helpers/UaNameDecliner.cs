namespace RGR.Helpers
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum GrammaticalCase
    {
        Nominative,
        Genitive,
        Dative,
        Accusative,
        Instrumental,
        Locative,
        Vocative
    }

    public static class UaNameDecliner
    {
        public static string Decline(string name, Gender gender, GrammaticalCase targetCase)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            return gender == Gender.Female
                ? DeclineFemale(name, targetCase)
                : DeclineMale(name, targetCase);
        }

        private static string DeclineFemale(string name, GrammaticalCase targetCase)
        {
            if (name.EndsWith("а", StringComparison.OrdinalIgnoreCase))
            {
                string baseName = name[..^1];
                return targetCase switch
                {
                    GrammaticalCase.Nominative => name,
                    GrammaticalCase.Genitive => baseName + "и",
                    GrammaticalCase.Dative => baseName + "і",
                    GrammaticalCase.Accusative => baseName + "у",
                    GrammaticalCase.Instrumental => baseName + "ою",
                    GrammaticalCase.Locative => baseName + "і",
                    GrammaticalCase.Vocative => baseName + "о",
                    _ => name
                };
            }
            if (name.EndsWith("я", StringComparison.OrdinalIgnoreCase))
            {
                string baseName = name[..^1];
                return targetCase switch
                {
                    GrammaticalCase.Nominative => name,
                    GrammaticalCase.Genitive => baseName + "і",
                    GrammaticalCase.Dative => baseName + "ї",
                    GrammaticalCase.Accusative => baseName + "ю",
                    GrammaticalCase.Instrumental => baseName + "ею",
                    GrammaticalCase.Locative => baseName + "ї",
                    GrammaticalCase.Vocative => baseName + "ю",
                    _ => name
                };
            }
            return name;
        }

        private static string DeclineMale(string name, GrammaticalCase targetCase)
        {
            if (string.IsNullOrEmpty(name))
                return name;

            var lastChar = name[^1];
            if (lastChar == 'о' || lastChar == 'О')
            {
                string baseName = name[..^1];
                if (targetCase == GrammaticalCase.Nominative)
                    return name;
                return DeclineMaleHardEnding(baseName, targetCase);
            }

            if (lastChar == 'й' || lastChar == 'ь')
            {
                string baseName = name[..^1];
                return DeclineMaleSoftEnding(baseName, targetCase);
            }
            return DeclineMaleHardEnding(name, targetCase);
        }

        private static string DeclineMaleSoftEnding(string baseName, GrammaticalCase targetCase)
        {
            return targetCase switch
            {
                GrammaticalCase.Nominative => baseName + "ій",
                GrammaticalCase.Genitive => baseName + "я",
                GrammaticalCase.Dative => baseName + "ю",
                GrammaticalCase.Accusative => baseName + "я",
                GrammaticalCase.Instrumental => baseName + "єм",
                GrammaticalCase.Locative => baseName + "ю",
                GrammaticalCase.Vocative => baseName + "ю",
                _ => baseName + "ій"
            };
        }

        private static string DeclineMaleHardEnding(string name, GrammaticalCase targetCase)
        {
            return targetCase switch
            {
                GrammaticalCase.Nominative => name,
                GrammaticalCase.Genitive => name + "а",
                GrammaticalCase.Dative => name + "у",
                GrammaticalCase.Accusative => name + "а",
                GrammaticalCase.Instrumental => name + "ом",
                GrammaticalCase.Locative => name + "ові",
                GrammaticalCase.Vocative => name + "е",
                _ => name
            };
        }
    }
}
