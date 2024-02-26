using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how merge Word documents without starting from a new page into single file.
    /// For more details about merging Microsoft Word Document (.doc) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/word/
    /// </summary>
    internal static class MergeWordDocumentsWithoutStartingFromNewPage
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.doc");
            
            // Load the source DOC file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOC))
            {
                // Define Word join options
                WordJoinOptions joinOptions = new WordJoinOptions();
                joinOptions.Mode = WordJoinMode.Continuous;
                // Add another DOC file to merge
                merger.Join(Constants.SAMPLE_DOC_2, joinOptions);
                // Merge DOC files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOC files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            