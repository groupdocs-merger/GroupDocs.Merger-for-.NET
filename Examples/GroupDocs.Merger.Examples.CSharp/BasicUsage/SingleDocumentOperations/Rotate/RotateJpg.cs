using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to rotate JPG.
    /// </summary>
    public class RotateJpg
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: Rotate JPG");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_JPG;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate90);

            using (Merger merger = new Merger(filePath))
            {
                merger.Rotate(rotateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source JPG was rotated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}