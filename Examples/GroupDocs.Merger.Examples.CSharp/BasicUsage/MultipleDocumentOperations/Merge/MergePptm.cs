using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PPTM files into single file.
    /// For more details about merging PowerPoint Open XML Presentation (.pptm) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/pptm
    /// </summary>
    internal static class MergePptm
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergePptm");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.pptm");
            
            // Load the source PPTM file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PPTM))
            {
                // Add another PPTM file to merge
                merger.Join(Constants.SAMPLE_PPTM);
                // Merge PPTM files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPPTM files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            