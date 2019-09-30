using System;

namespace GroupDocs.Merger.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to load document from local disk
    /// </summary>
    public class LoadDocumentFromLocalDisk
    {       
        public static void Run()
        {
            // The path to the documents directory.
            string filePath = Constants.SAMPLE_DOCX;
            using (Merger merger = new Merger(filePath))
            {
                Console.WriteLine($"Document loaded from local disk successfully.");
            }
        }
    }
}