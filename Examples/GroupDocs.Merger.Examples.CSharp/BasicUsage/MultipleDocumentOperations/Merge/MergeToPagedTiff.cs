using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple TIFF files into single multi-paged file.
    /// </summary>
    internal static class MergeToPagedTiff
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeToPagedTiff");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.tiff");
            
            // Load the source TIFF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_TIFF))
            {
                // Define join options
                var joinOptions = new GroupDocs.Merger.Domain.Options.JoinOptions(GroupDocs.Merger.Domain.FileType.TIFF);
                // Add another TIFF file to merge
                merger.Join(Constants.SAMPLE_TIFF, joinOptions);
                // Merge TIFF files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nTIFF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}