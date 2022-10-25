using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple PPTX files into single file.
    /// For more details about merging PowerPoint Open XML Presentation (.pptx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/pptx
    /// </summary>
    internal static class MergePptx
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.pptx");
            
            // Load the source PPTX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_PPTX))
            {
                // Add another PPTX file to merge
                merger.Join(Constants.SAMPLE_PPTX_2);
                // Merge PPTX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nPPTX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            