using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple MHT files into single file.
    /// For more details about merging MIME Encapsulation of Aggregate HTML (.mht) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/mht
    /// </summary>
    internal static class MergeMht
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeMht");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.mht");
            
            // Load the source MHT file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_MHT))
            {
                // Add another MHT file to merge
                merger.Join(Constants.SAMPLE_MHT_2);
                // Merge MHT files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nMHT files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            