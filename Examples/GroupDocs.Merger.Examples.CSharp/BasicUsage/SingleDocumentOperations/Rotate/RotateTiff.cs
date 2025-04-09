using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to rotate TIFF.
    /// </summary>
    public class RotateTiff
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: Rotate TIFF");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_TIFF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate270);

            using (Merger merger = new Merger(filePath))
            {
                merger.Rotate(rotateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source TIFF was rotated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}