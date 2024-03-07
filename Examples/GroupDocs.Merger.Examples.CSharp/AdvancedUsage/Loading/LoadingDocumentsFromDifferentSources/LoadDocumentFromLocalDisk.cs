using System;

namespace GroupDocs.Merger.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load document from local disk
    /// </summary>
    public class LoadDocumentFromLocalDisk
    {       
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Advanced Usage: LoadDocumentFromLocalDisk");
            Console.WriteLine();

            // The path to the documents directory.
            string filePath = Constants.SAMPLE_DOCX;
            using (Merger merger = new Merger(filePath))
            {
                Console.WriteLine("Document loaded from local disk successfully.");
            }
        }
    }
}