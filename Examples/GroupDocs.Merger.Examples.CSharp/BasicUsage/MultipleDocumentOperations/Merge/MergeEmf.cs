using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple EMF files into single file.
    /// For more details about merging image (.emf) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// </summary>
    internal static class MergeEmf
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeEmf");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.emf");
            
            // Load the source EMF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_EMF))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another EMF file to merge
                merger.Join(Constants.SAMPLE_EMF, joinOptions);
                // Merge EMF files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nEMF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}