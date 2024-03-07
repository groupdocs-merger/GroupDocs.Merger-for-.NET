using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLTX files into single file.
    /// For more details about merging Microsoft Excel Open XML Template (.xltx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xltx
    /// </summary>
    internal static class MergeXltx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeXltx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xltx");
            
            // Load the source XLTX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLTX))
            {
                // Add another XLTX file to merge
                merger.Join(Constants.SAMPLE_XLTX_2);
                // Merge XLTX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLTX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            