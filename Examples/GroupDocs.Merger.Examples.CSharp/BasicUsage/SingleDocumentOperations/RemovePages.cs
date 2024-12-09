using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to remove document pages.
    /// </summary>
    public class RemovePages
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: RemovePages");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_VSDX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            RemoveOptions removeOptions = new RemoveOptions(new int[] { 3, 5 });

            using (Merger merger = new Merger(filePath))
            {
                merger.RemovePages(removeOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document pages were removed successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}