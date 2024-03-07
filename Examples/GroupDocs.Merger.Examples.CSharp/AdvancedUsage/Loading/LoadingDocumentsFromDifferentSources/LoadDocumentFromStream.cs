using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load document from stream
    /// </summary>
    public class LoadDocumentFromStream
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Advanced Usage: LoadDocumentFromStream");
            Console.WriteLine();

            using (Stream stream = File.OpenRead(Constants.SAMPLE_DOCX))
            {
                using (Merger merger = new Merger(stream))
                {
                    Console.WriteLine($"Document loaded from stream successfully.");
                }
            }
        }
    }
}

