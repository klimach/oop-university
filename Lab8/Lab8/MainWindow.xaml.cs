using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace Lab8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };

            cmbFontSize.Loaded += (s, e) =>
            {
                if (cmbFontSize.Template.FindName("PART_EditableTextBox", cmbFontSize) is TextBox textBox)
                {
                    textBox.TextChanged += cmbFontSize_TextChanged;
                }
            };
        }

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp;

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && temp.Equals(FontWeights.Bold);

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && temp.Equals(FontStyles.Italic);

            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && temp.Equals(TextDecorations.Underline);

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                using FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                using FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size);
            }
        }

        private void cmbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size);
            }
        }

        private void cmbFontSize_LostFocus(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
            {
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size);
            }
        }

        private void InsertImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*"
            };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(dlg.FileName));
                    Image image = new Image
                    {
                        Source = bitmap,
                        Width = 200
                    };

                    InlineUIContainer container = new InlineUIContainer(image, rtbEditor.CaretPosition);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting image: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void AlignLeft_Click(object sender, RoutedEventArgs e)
        {
            Paragraph paragraph = GetCurrentParagraph();
            if (paragraph != null)
                paragraph.TextAlignment = TextAlignment.Left;
        }

        private void AlignCenter_Click(object sender, RoutedEventArgs e)
        {
            Paragraph paragraph = GetCurrentParagraph();
            if (paragraph != null)
                paragraph.TextAlignment = TextAlignment.Center;
        }

        private void AlignRight_Click(object sender, RoutedEventArgs e)
        {
            Paragraph paragraph = GetCurrentParagraph();
            if (paragraph != null)
                paragraph.TextAlignment = TextAlignment.Right;
        }
        private Paragraph GetCurrentParagraph()
        {
            TextPointer caret = rtbEditor.CaretPosition;
            return caret.Paragraph;
        }
    }
}
