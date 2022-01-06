using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to rotate document pages.
    /// </summary>
    public class RotatePages
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_PDF_2;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate180, new int[] { 1 });

            using (Merger merger = new Merger(filePath))
            {
                merger.RotatePages(rotateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document was rotated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}