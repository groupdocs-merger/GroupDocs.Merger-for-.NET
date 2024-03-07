using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple DOC files into single file.
    /// For more details about merging Microsoft Word Document (.doc) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/word/
    /// </summary>
    internal static class MergeDoc
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeDoc");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.doc");
            
            // Load the source DOC file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOC))
            {
                // Add another DOC file to merge
                merger.Join(Constants.SAMPLE_DOC_2);
                // Merge DOC files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOC files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            