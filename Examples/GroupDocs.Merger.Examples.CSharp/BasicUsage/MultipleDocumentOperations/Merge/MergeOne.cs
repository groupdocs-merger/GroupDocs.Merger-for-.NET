using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple ONE files into single file.
    /// For more details about merging Microsoft OneNote File Format (.one) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/one
    /// </summary>
    internal static class MergeOne
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeOne");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.one");
            
            // Load the source ONE file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_ONE))
            {
                // Add another ONE file to merge
                merger.Join(Constants.SAMPLE_ONE_2);
                // Merge ONE files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nONE files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            