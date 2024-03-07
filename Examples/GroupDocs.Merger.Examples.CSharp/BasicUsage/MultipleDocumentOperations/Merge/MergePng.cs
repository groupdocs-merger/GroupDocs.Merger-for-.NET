using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PNG files into single file.
    /// For more details about merging image (.png) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// https://docs.groupdocs.com/merger/net/getting-started/use-cases/how-to-merge-png-images-using-csharp/
    /// </summary>
    internal static class MergePng
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergePng");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.png");
            
            // Load the source PNG file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PNG))
            {
                // Define image join options with horizontal join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Horizontal);
                // Add another PNG file to merge
                merger.Join(Constants.SAMPLE_PNG, joinOptions);
                // Merge PNG files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPNG files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}