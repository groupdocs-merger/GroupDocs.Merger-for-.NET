using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add the OLE object to the Spreadsheet document page.
    /// </summary>
    public class ImportDocumentToSpreadsheet
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: ImportDocumentToSpreadsheet");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_XLSX;
            string embeddedFilePath = Constants.SAMPLE_PDF;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            int pageNumber = 2;
            OleSpreadsheetOptions oleCellsOptions = new OleSpreadsheetOptions(embeddedFilePath, pageNumber);
            oleCellsOptions.RowIndex = 2;
            oleCellsOptions.ColumnIndex = 2;

            using (Merger merger = new Merger(filePath))
            {
                merger.ImportDocument(oleCellsOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Embedded object was added to the source document page successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}