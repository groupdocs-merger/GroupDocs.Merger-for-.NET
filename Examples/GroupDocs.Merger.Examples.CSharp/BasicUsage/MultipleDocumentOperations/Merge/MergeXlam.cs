using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLAM files into single file.
    /// For more details about merging Microsoft Excel Macro-Enabled Add-In (.xlam) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xlam
    /// </summary>
    internal static class MergeXlam
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeXlam");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlam");
            
            // Load the source XLAM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLAM))
            {
                // Add another XLAM file to merge
                merger.Join(Constants.SAMPLE_XLAM_2);
                // Merge XLAM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLAM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            