using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VSSX files into single file.
    /// For more details about merging Visio Stencil File Format (.vssx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vssx
    /// </summary>
    internal static class MergeVssx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeVssx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vssx");
            
            // Load the source VSSX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VSSX))
            {
                // Add another VSSX file to merge
                merger.Join(Constants.SAMPLE_VSSX_2);
                // Merge VSSX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVSSX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            