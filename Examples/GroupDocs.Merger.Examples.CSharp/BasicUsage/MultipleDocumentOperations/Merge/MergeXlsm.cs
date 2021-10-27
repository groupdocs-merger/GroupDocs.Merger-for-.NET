using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple XLSM files into single file.
    /// For more details about merging Microsoft Excel Macro-Enabled Spreadsheet (.xlsm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/xlsm
    /// </summary>
    internal static class MergeXlsm
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.xlsm");
            
            // Load the source XLSM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_XLSM))
            {
                // Add another XLSM file to merge
                merger.Join(Constants.SAMPLE_XLSM_2);
                // Merge XLSM files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nXLSM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            