using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple Mp3 files into single file.
    /// For more details about merging Archive (.mp3) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/audio/
    /// </summary>
    internal static class MergeMp3
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.mp3");
            
            // Load the source Mp3 file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_MP3))
            {
                // Add another Mp3 file to merge
                merger.Join(Constants.SAMPLE_MP3);
                // Merge Mp3 files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nMp3 files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            