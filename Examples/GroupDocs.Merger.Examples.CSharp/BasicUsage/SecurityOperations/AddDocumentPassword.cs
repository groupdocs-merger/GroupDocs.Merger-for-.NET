using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add password to document.
    /// </summary>
    public class AddDocumentPassword
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: AddDocumentPassword");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_PPTX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            AddPasswordOptions addOptions = new AddPasswordOptions(Constants.SAMPLE_PASSWORD);

            using (Merger merger = new Merger(filePath))
            {
                merger.AddPassword(addOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document password was added successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}