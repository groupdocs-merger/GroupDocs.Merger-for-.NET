using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple GIF files into single file.
    /// For more details about merging image (.gif) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// https://docs.groupdocs.com/merger/net/getting-started/use-cases/how-to-merge-gif-images-using-csharp/
    /// </summary>
    internal static class MergeGif
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.gif");
            
            // Load the source GIF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_GIF))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another GIF file to merge
                merger.Join(Constants.SAMPLE_GIF, joinOptions);
                // Merge GIF files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nGIF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}