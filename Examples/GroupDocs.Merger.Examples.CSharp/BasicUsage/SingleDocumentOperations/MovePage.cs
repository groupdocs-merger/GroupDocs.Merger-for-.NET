using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to move document page to a new position.
    /// </summary>
    public class MovePage
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MovePage");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_XLSX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            int pageNumber = 6;
            int newPageNumber = 1;
            MoveOptions moveOptions = new MoveOptions(pageNumber, newPageNumber);

            using (Merger merger = new Merger(filePath))
            {
                merger.MovePage(moveOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document page was moved successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}