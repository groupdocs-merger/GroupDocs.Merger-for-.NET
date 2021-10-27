using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple OTT files into single file.
    /// For more details about merging Open Document Template (.ott) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/ott
    /// </summary>
    internal static class MergeOtt
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.ott");
            
            // Load the source OTT file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_OTT))
            {
                // Add another OTT file to merge
                merger.Join(Constants.SAMPLE_OTT_2);
                // Merge OTT files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nOTT files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            