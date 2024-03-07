using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PPSX files into single file.
    /// For more details about merging PowerPoint Open XML Slide Show (.ppsx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/ppsx
    /// </summary>
    internal static class MergePpsx
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergePpsx");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.ppsx");
            
            // Load the source PPSX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PPSX))
            {
                // Add another PPSX file to merge
                merger.Join(Constants.SAMPLE_PPSX_2);
                // Merge PPSX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPPSX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            