using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to remove document password.
    /// </summary>
    public class RemoveDocumentPassword
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX_PROTECTED;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            LoadOptions loadOptions = new LoadOptions(Constants.SAMPLE_PASSWORD);

            using (Merger merger = new Merger(filePath, loadOptions))
            {
                merger.RemovePassword();
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document password was removed successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}