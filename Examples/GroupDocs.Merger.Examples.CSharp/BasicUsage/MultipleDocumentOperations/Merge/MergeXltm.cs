using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLTM files into single file.
    /// For more details about merging Microsoft Excel Macro-Enabled Template (.xltm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xltm
    /// </summary>
    internal static class MergeXltm
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeXltm");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xltm");
            
            // Load the source XLTM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLTM))
            {
                // Add another XLTM file to merge
                merger.Join(Constants.SAMPLE_XLTM_2);
                // Merge XLTM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLTM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            