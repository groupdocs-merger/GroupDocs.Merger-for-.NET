using System;
using System.IO;
using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to update document password.
    /// </summary>
    public class UpdateDocumentPassword
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: UpdateDocumentPassword");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_XLSX_PROTECTED;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            LoadOptions loadOptions = new LoadOptions(Constants.SAMPLE_PASSWORD);
            UpdatePasswordOptions updateOptions = new UpdatePasswordOptions(Constants.SAMPLE_PASSWORD + Constants.SAMPLE_PASSWORD);

            using (Merger merger = new Merger(filePath, loadOptions))
            {
                merger.UpdatePassword(updateOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document password was updated successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}