using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple TEX files into single file.
    /// For more details about merging LaTeX Source Document (.tex) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/tex
    /// </summary>
    internal static class MergeTex
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.tex");
            
            // Load the source TEX file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_TEX))
            {
                // Add another TEX file to merge
                merger.Join(Constants.SAMPLE_TEX_2);
                // Merge TEX files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nTEX files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            