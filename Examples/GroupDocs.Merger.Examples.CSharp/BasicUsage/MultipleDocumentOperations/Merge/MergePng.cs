using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PNG files into single file.
    /// For more details about merging PNG (.png) image files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// </summary>
    internal static class MergePng
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.png");
            
            // Load the source PNG file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PNG))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another PNG file to merge
                merger.Join(Constants.SAMPLE_PNG, joinOptions);
                // Merge PNG files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPNG files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}