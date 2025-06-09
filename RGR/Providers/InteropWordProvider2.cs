using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace RGR.Providers
{
    public class InteropWordProvider2 : IDisposable
    {
        private Word.Application _wordApp;
        private bool _disposed = false;

        public InteropWordProvider2()
        {
            _wordApp = new Word.Application
            {
                Visible = false
            };
        }

        public void GenerateDocumentFromTemplate(
            string templatePath, string outputPath, 
            Dictionary<string, string> placeholders)
        {
            Word.Document? doc = null;

            try
            {
                doc = _wordApp.Documents.Open(templatePath);

                foreach (var pair in placeholders)
                {
                    Word.Find findObject = _wordApp.Selection.Find;
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
                if (doc != null)
                {
                    doc.Close(false);
                    Marshal.ReleaseComObject(doc);
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (_wordApp != null)
                {
                    _wordApp.Quit(false);
                    Marshal.ReleaseComObject(_wordApp);
                    _wordApp = null;
                }

                _disposed = true;
            }
        }

        ~InteropWordProvider2()
        {
            Dispose(false);
        }
    }
}