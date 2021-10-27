using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple VDX files into single file.
    /// For more details about merging Microsoft Visio XML Drawing File Format (.vdx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/vdx
    /// </summary>
    internal static class MergeVdx
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.vdx");
            
            // Load the source VDX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_VDX))
            {
                // Add another VDX file to merge
                merger.Join(Constants.SAMPLE_VDX_2);
                // Merge VDX files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nVDX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            