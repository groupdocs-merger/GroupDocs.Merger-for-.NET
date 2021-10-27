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
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlsb");
            
            // Load the source XLSB file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLSB))
            {
                // Add another XLSB file to merge
                merger.Join(Constants.SAMPLE_XLSB_2);
                // Merge XLSB files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLSB files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            