using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple EMZ files into single file.
    /// For more details about merging image (.emz) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// </summary>
    internal static class MergeEmz
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeEmz");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.emz");
            
            // Load the source EMZ file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_EMZ))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another EMZ file to merge
                merger.Join(Constants.SAMPLE_EMZ, joinOptions);
                // Merge EMZ files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nEMZ files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}