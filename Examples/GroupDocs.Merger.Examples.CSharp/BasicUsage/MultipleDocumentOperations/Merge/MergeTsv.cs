using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple TSV files into single file.
    /// For more details about merging Tab Separated Values File (.tsv) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/tsv
    /// </summary>
    internal static class MergeTsv
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.tsv");
            
            // Load the source TSV file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_TSV))
            {
                // Add another TSV file to merge
                merger.Join(Constants.SAMPLE_TSV_2);
                // Merge TSV files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nTSV files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            