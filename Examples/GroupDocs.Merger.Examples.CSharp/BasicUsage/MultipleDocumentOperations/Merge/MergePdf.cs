using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PDF files into single file.
    /// For more details about merging Portable Document (.pdf) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/pdf
    /// </summary>
    internal static class MergePdf
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergePdf");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.pdf");
            
            // Load the source PDF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PDF))
            {
                // Add another PDF file to merge
                merger.Join(Constants.SAMPLE_PDF_2);
                // Merge PDF files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPDF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}