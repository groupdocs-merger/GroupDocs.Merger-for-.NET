using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to rotate TIF pages.
    /// </summary>
    public class RotateTifPages
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: Rotate TIF Pages");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_TIF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate90, new int[] { 1 });

            using (Merger merger = new Merger(filePath))
            {
                merger.RotatePages(rotateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source TIF pages were rotated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}