using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how merge Word documents with pre-defined Compliance mode into single file.
    /// For more details about merging Microsoft Word Document (.docx) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/word/
    /// </summary>
    internal static class MergeWordDocumentsWithPredefinedComplianceMode
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeWordDocumentsWithPredefinedComplianceMode");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.docx");
            
            // Load the source DOCX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_DOCX))
            {
                // Define Word join options
                WordJoinOptions joinOptions = new WordJoinOptions();
                joinOptions.Compliance = WordJoinCompliance.Iso29500_2008_Strict;
                // Add another DOCX file to merge
                merger.Join(Constants.SAMPLE_DOCX_2, joinOptions);
                // Merge DOCX files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nDOCX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            