using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple RTF files into single file.
    /// For more details about merging Rich Text File Format (.rtf) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/rtf
    /// </summary>
    internal static class MergeRtf
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.rtf");
            
            // Load the source RTF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_RTF))
            {
                // Add another RTF file to merge
                merger.Join(Constants.SAMPLE_RTF_2);
                // Merge RTF files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nRTF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}