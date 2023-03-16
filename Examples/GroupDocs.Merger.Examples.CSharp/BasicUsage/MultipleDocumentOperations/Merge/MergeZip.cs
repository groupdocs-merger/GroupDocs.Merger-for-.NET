using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple ZIP files into single file.
    /// For more details about merging Archive (.zip) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/archives/
    /// </summary>
    internal static class MergeZip
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.zip");
            
            // Load the source ZIP file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_ZIP))
            {
                // Add another ZIP file to merge
                merger.Join(Constants.SAMPLE_ZIP);
                // Merge ZIP files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nZIP files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            