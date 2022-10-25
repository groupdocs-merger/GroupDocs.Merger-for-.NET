using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple TIF files into single file.
    /// For more details about merging image (.tif) files please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/images/
    /// https://docs.groupdocs.com/merger/net/getting-started/use-cases/how-to-merge-tif-images-using-csharp/
    /// </summary>
    internal static class MergeTif
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.tif");
            
            // Load the source TIF file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_TIF))
            {
                // Add another TIF file to merge
                merger.Join(Constants.SAMPLE_TIF);
                // Merge TIF files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nTIF files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}