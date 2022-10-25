using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VSTM files into single file.
    /// For more details about merging Visio Macro-Enabled Drawing Template (.vstm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vstm
    /// </summary>
    internal static class MergeVstm
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vstm");
            
            // Load the source VSTM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VSTM))
            {
                // Add another VSTM file to merge
                merger.Join(Constants.SAMPLE_VSTM_2);
                // Merge VSTM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVSTM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            