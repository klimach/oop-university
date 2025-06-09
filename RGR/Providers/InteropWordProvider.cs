using RGR.Interfaces;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace RGR.Providers
{
    public class InteropWordProvider : IWordProvider
    {
        public void GenerateDocumentFromTemplate(string templatePath, string outputPath, Dictionary<string, string> placeholders)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document? doc = null;

            try
            {
                wordApp.Visible = false;

                doc = wordApp.Documents.Open(templatePath);

                foreach (var pair in placeholders)
                {
                    Word.Find findObject = wordApp.Selection.Find;
                    findObject.ClearFormatting();
                    findObject.Text = pair.Key;
                    findObject.Replacement.ClearFormatting();
                    findObject.Replacement.Text = pair.Value;

                    object replaceAll = Word.WdReplace.wdReplaceAll;
                    findObject.Execute(Replace: ref replaceAll);
                }

                doc.SaveAs2(outputPath);
            }
            finally
            {
                doc?.Close(false);
                wordApp.Quit(false);

                Marshal.ReleaseComObject(doc);
                Marshal.ReleaseComObject(wordApp);
            }
        }
    }
}
