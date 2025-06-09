using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace Lab12
{
    public class WordTemplateProvider : IDisposable
    {
        private Word.Application? _wordApp;
        private Word.Document? _document;
        private bool _disposed;

        public WordTemplateProvider(string templatePath)
        {
            _wordApp = new Word.Application
            {
                Visible = false,
                DisplayAlerts = Word.WdAlertLevel.wdAlertsNone
            };
            _document = _wordApp.Documents.Open(templatePath, ReadOnly: false);
        }

        public void ReplacePlaceholder(string placeholder, string replacement)
        {
            Word.Find findObject = _wordApp!.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = placeholder;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replacement;

            object replaceAll = Word.WdReplace.wdReplaceAll;

            Word.Range range = _document.Content;
            range.Find.Execute(FindText: placeholder,
                               ReplaceWith: replacement,
                               Replace: replaceAll);
        }

        public void SaveAs(string outputPath)
        {
            _document!.SaveAs2(outputPath);
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            try
            {
                if (_document != null)
                {
                    _document.Close(SaveChanges: false);
                    Marshal.ReleaseComObject(_document);
                }

                if (_wordApp != null)
                {
                    _wordApp.Quit();
                    Marshal.ReleaseComObject(_wordApp);
                }
            }
            catch
            { }
            finally
            {
                _document = null;
                _wordApp = null;
                _disposed = true;
                GC.SuppressFinalize(this);
            }
        }
    }
}
