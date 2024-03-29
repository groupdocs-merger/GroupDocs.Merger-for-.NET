using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOTX files into single file.
    /// For more details about merging Word Open XML Document Template (.dotx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/word/
    /// </summary>
    internal static class MergeDotx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeDotx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.dotx");
            
            // Load the source DOTX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOTX))
            {
                // Add another DOTX file to merge
                merger.Join(Constants.SAMPLE_DOTX_2);
                // Merge DOTX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOTX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            