using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple SVG files into single file.
    /// For more details about merging image (.svg) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// </summary>
    internal static class MergeSvg
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.svg");
            
            // Load the source SVG file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_SVG))
            {
                // Define image join options with vertical join mode
                var joinOptions = new GroupDocs.Merger.Domain.Options.ImageJoinOptions(GroupDocs.Merger.Domain.Options.ImageJoinMode.Vertical);
                // Add another SVG file to merge
                merger.Join(Constants.SAMPLE_SVG, joinOptions);
                // Merge SVG files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nSVG files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}