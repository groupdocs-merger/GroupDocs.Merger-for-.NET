using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLSX files into single file.
    /// For more details about merging Microsoft Excel Open XML Spreadsheet (.xlsx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xlsx
    /// </summary>
    internal static class MergeXlsx
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlsx");
            
            // Load the source XLSX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLSX))
            {
                // Add another XLSX file to merge
                merger.Join(Constants.SAMPLE_XLSX_2);
                // Merge XLSX files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLSX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            