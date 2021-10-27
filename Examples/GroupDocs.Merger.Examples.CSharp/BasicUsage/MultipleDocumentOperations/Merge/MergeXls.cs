using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLS files into single file.
    /// For more details about merging Microsoft Excel Binary File Format (.xls) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xls
    /// </summary>
    internal static class MergeXls
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xls");
            
            // Load the source XLS file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLS))
            {
                // Add another XLS file to merge
                merger.Join(Constants.SAMPLE_XLS_2);
                // Merge XLS files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLS files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            