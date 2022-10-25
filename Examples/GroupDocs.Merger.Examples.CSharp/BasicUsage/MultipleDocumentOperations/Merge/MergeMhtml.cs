using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple MHTML files into single file.
    /// For more details about merging MIME Encapsulation of Aggregate HTML (.mhtml) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/mhtml
    /// </summary>
    internal static class MergeMhtml
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.mhtml");
            
            // Load the source MHTML file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_MHTML))
            {
                // Add another MHTML file to merge
                merger.Join(Constants.SAMPLE_MHTML_2);
                // Merge MHTML files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nMHTML files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            