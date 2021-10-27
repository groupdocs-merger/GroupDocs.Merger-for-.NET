using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple EPUB files into single file.
    /// For more details about merging Digital E-Book File Format (.epub) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/epub
    /// </summary>
    internal static class MergeEpub
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.epub");
            
            // Load the source EPUB file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_EPUB))
            {
                // Add another EPUB file to merge
                merger.Join(Constants.SAMPLE_EPUB_2);
                // Merge EPUB files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nEPUB files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            