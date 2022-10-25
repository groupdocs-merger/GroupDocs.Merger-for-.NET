using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple ODT files into single file.
    /// For more details about merging Open Document Text (.odt) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/odt
    /// </summary>
    internal static class MergeOdt
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.odt");
            
            // Load the source ODT file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_ODT))
            {
                // Add another ODT file to merge
                merger.Join(Constants.SAMPLE_ODT_2);
                // Merge ODT files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nODT files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            