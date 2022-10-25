using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOCX files into single file.
    /// For more details about merging Microsoft Word Open XML Document (.docx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/docx
    /// </summary>
    internal static class MergeDocx
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.docx");
            
            // Load the source DOCX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOCX))
            {
                // Add another DOCX file to merge
                merger.Join(Constants.SAMPLE_DOCX_2);
                // Merge DOCX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOCX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            