using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOTM files into single file.
    /// For more details about merging Microsoft Word Macro-Enabled Template (.dotm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/dotm
    /// </summary>
    internal static class MergeDotm
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.dotm");
            
            // Load the source DOTM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOTM))
            {
                // Add another DOTM file to merge
                merger.Join(Constants.SAMPLE_DOTM_2);
                // Merge DOTM files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOTM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            