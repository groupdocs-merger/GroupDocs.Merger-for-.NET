using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VTX files into single file.
    /// For more details about merging Microsoft Visio Drawing Template (.vtx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vtx
    /// </summary>
    internal static class MergeVtx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeVtx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vtx");
            
            // Load the source VTX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VTX))
            {
                // Add another VTX file to merge
                merger.Join(Constants.SAMPLE_VTX_2);
                // Merge VTX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVTX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            