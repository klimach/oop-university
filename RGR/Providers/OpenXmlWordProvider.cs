using DocumentFormat.OpenXml.Packaging;
using RGR.Interfaces;

namespace RGR.Providers
{
    public class OpenXmlWordProvider : IWordProvider
    {
        public void GenerateDocumentFromTemplate(
            string templatePath, string outputPath, 
            Dictionary<string, string> placeholders)
        {
            //TODO: Занадто спрощена логіка, деякі плейсхолдери не замінюються як очікується.

            File.Copy(templatePath, outputPath, true);

            using WordprocessingDocument wordDoc = WordprocessingDocument.Open(outputPath, true);
            using StreamReader reader = new(wordDoc.MainDocumentPart!.GetStream());
            string templateContent = reader.ReadToEnd();
            reader.Close();

            foreach (var placeholder in placeholders)
            {
                templateContent = templateContent.Replace(placeholder.Key, placeholder.Value);
            }

            using StreamWriter writer = new(wordDoc.MainDocumentPart.GetStream(FileMode.Create));
            writer.Write(templateContent);
            writer.Close();

            wordDoc.Save();
            wordDoc.Dispose();
        }
    }
}
