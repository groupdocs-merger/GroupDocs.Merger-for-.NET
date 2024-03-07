using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VSDM files into single file.
    /// For more details about merging Visio Macro-Enabled Drawing (.vsdm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vsdm
    /// </summary>
    internal static class MergeVsdm
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeVsdm");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vsdm");
            
            // Load the source VSDM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VSDM))
            {
                // Add another VSDM file to merge
                merger.Join(Constants.SAMPLE_VSDM_2);
                // Merge VSDM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVSDM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            