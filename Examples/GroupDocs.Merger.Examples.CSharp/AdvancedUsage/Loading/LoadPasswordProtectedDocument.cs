using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load password-protected document
    /// </summary>
    public class LoadPasswordProtectedDocument
    {       
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_DOCX_PROTECTED;

            LoadOptions loadOptions = new LoadOptions("SAMPLE_PASSWORD");

            using (Merger merger = new Merger(filePath, loadOptions))
            {
                Console.WriteLine($"Document loaded successfully.");                
            }            
        }
    }
}