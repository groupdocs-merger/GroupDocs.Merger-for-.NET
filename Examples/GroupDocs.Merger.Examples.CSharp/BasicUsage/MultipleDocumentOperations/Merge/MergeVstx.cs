using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VSTX files into single file.
    /// For more details about merging Microsoft Visio File Format (.vstx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vstx
    /// </summary>
    internal static class MergeVstx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeVstx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vstx");
            
            // Load the source VSTX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VSTX))
            {
                // Add another VSTX file to merge
                merger.Join(Constants.SAMPLE_VSTX_2);
                // Merge VSTX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVSTX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            