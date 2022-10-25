using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple ODP files into single file.
    /// For more details about merging OpenDocument Presentation File Format (.odp) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/odp
    /// </summary>
    internal static class MergeOdp
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.odp");
            
            // Load the source ODP file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_ODP))
            {
                // Add another ODP file to merge
                merger.Join(Constants.SAMPLE_ODP_2);
                // Merge ODP files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nODP files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            