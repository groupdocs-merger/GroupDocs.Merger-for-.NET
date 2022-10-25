using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOCM files into single file.
    /// For more details about merging Microsoft Word Macro-Enabled Document (.docm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/docm
    /// </summary>
    internal static class MergeDocm
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.docm");
            
            // Load the source DOCM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOCM))
            {
                // Add another DOCM file to merge
                merger.Join(Constants.SAMPLE_DOCM_2);
                // Merge DOCM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOCM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            