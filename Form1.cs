using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FindAndReplace(word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object MatchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundlike = false;
            object nmatchAllforms = false;
            object foward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object mathcAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(
                ref ToFindText, ref MatchCase,
                ref matchWholeWord, ref matchWildCards,
                ref matchSoundlike, ref nmatchAllforms,
                ref foward, ref wrap,
                ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref mathcAlefHamza,
                ref matchControl);
        }

        private void CreateWordDocument(object template, object SaveAs)
        {
            word.Application wordApp = new word.Application();
            object missing = Missing.Value;
            word.Document myWordDoc = null;

            if (File.Exists((string)template))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(
                    ref template, ref missing,
                    ref readOnly, ref missing,
                    ref missing, ref missing,
                    ref missing, ref missing,
                    ref missing, ref missing,
                    ref missing, ref missing,
                    ref missing);

                myWordDoc.Activate();

                //Find and replace function
                this.FindAndReplace(wordApp, "<name>", TBname.Text);
                this.FindAndReplace(wordApp, "<surname>", TBsurname.Text);
                this.FindAndReplace(wordApp, "<text1>", TBtext1.Text);
                this.FindAndReplace(wordApp, "<text2>", TBtext2.Text);
                this.FindAndReplace(wordApp, "<text3>", TBtext3.Text);
                this.FindAndReplace(wordApp, "<date>", DateTime.Now.ToShortDateString());
            }

            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(
                ref SaveAs, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing,
                ref missing, ref missing
                );

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateWordDocument(@"C:\Users\37126\source\repos\WinFormsApp\template.docx", @"C:\Users\37126\source\repos\WinFormsApp\Generated.docx");
        }
    }
}