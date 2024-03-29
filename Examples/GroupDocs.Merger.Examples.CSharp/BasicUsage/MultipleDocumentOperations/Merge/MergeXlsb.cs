using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLSB files into single file.
    /// For more details about merging Microsoft Excel Binary Spreadsheet File (.xlsb) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xlsb
    /// </summary>
    internal static class MergeXlsb
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeXlsb");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlsb");
            
            // Load the source XLSB file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLSB))
            {
                // Add another XLSB file to merge
                merger.Join(Constants.SAMPLE_XLSB_2);
                // Merge XLSB files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLSB files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            