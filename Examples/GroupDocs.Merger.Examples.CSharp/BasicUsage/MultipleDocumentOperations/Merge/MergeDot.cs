using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOT files into single file.
    /// For more details about merging Microsoft Word Document Template (.dot) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/dot
    /// </summary>
    internal static class MergeDot
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.dot");
            
            // Load the source DOT file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOT))
            {
                // Add another DOT file to merge
                merger.Join(Constants.SAMPLE_DOT_2);
                // Merge DOT files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOT files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            