namespace RGR.Interfaces
{
    public interface IWordProvider
    {
        public void GenerateDocumentFromTemplate(
            string templatePath, string outputPath, 
            Dictionary<string, string> placeholders);
    }
}
