using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple HTML files into single file.
    /// For more details about merging Hyper Text Markup Language (.html) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/html
    /// </summary>
    internal static class MergeHtml
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.html");
            
            // Load the source HTML file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_HTML))
            {
                // Add another HTML file to merge
                merger.Join(Constants.SAMPLE_HTML_2);
                // Merge HTML files ans save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nHTML files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            