using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge multiple Wav files into single file.
    /// For more details about merging Archive (.wav) files please check this documentation article 
    /// https://docs.groupdocs.com/merger/net/merge/audio/
    /// </summary>
    internal static class MergeWav
    {
        public static void Run()
        {            
            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged.wav");
            
            // Load the source Wav file
            using (var merger = new GroupDocs.Merger.Merger(Constants.SAMPLE_WAV))
            {
                // Add another Wav file to merge
                merger.Join(Constants.SAMPLE_WAV);
                // Merge Wav files and save result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nWav files merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}

            
            