using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple CSV files into single file.
    /// For more details about merging Comma Separated Values File (.csv) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/csv
    /// </summary>
    internal static class MergeCsv
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.csv");
            
            // Load the source CSV file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_CSV))
            {
                // Add another CSV file to merge
                merger.Join(Constants.SAMPLE_CSV_2);
                // Merge CSV files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nCSV files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            