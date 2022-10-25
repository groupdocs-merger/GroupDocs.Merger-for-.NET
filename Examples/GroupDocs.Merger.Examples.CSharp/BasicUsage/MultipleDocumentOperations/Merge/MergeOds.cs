using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple ODS files into single file.
    /// For more details about merging Open Document Spreadsheet (.ods) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/ods
    /// </summary>
    internal static class MergeOds
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.ods");
            
            // Load the source ODS file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_ODS))
            {
                // Add another ODS file to merge
                merger.Join(Constants.SAMPLE_ODS_2);
                // Merge ODS files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nODS files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            