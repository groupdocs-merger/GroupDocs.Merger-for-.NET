using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple 7Z files into single file.
    /// For more details about merging Archive (.7z) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/archives/
    /// </summary>
    internal static class Merge7z
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.7z");
            
            // Load the source 7Z file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_7Z))
            {
                // Add another 7Z file to merge
                merger.Join(Constants.SAMPLE_7Z);
                // Merge 7Z files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\n7Z files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            