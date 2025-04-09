using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to rotate BMP.
    /// </summary>
    public class RotateBmp
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: Rotate BMP");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_BMP;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate270);

            using (Merger merger = new Merger(filePath))
            {
                merger.Rotate(rotateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source BMP was rotated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}