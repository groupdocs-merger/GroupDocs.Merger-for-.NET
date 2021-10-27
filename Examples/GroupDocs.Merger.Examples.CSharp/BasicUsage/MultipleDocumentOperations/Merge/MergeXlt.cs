using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLT files into single file.
    /// For more details about merging Microsoft Excel Template (.xlt) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xlt
    /// </summary>
    internal static class MergeXlt
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlt");
            
            // Load the source XLT file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLT))
            {
                // Add another XLT file to merge
                merger.Join(Constants.SAMPLE_XLT_2);
                // Merge XLT files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLT files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            