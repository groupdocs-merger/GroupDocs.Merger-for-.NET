using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to join two documents.
    /// </summary>
    public class HelloWorld
    {
        public static void Run()
        {
            string firstDocPath = Constants.SAMPLE_DOCX;
            string secondDocPath = Constants.SAMPLE_DOCX_2;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(firstDocPath));

            using (Merger merger = new Merger(firstDocPath))
            {
                merger.Join(secondDocPath);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document was merged successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}