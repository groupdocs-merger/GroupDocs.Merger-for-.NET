using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to swap document pages.
    /// </summary>
    public class SwapPages
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_PPTX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            int pageNumber1 = 3;
            int pageNumber2 = 6;
            SwapOptions swapOptions = new SwapOptions(pageNumber2, pageNumber1);

            using (Merger merger = new Merger(filePath))
            {
                merger.SwapPages(swapOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document was swapped successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}