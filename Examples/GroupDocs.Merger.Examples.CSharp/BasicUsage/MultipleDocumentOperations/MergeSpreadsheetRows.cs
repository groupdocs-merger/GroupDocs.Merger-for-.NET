using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to merge the rows of several spreadsheets into a single sheet.
    /// For more details please check this documentation article
    /// https://docs.groupdocs.com/merger/net/merge/excel/#how-to-merge-rows-of-several-spreadsheets-into-a-single-sheet
    /// </summary>
    internal static class MergeSpreadsheetRows
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: MergeSpreadsheetRows");
            Console.WriteLine();

            string outputFolder = Constants.GetOutputDirectoryPath();
            string outputFile = Path.Combine(outputFolder, "merged-rows.xlsx");

            // Append the rows of each joined file below the last row with data of the matching sheet,
            // skipping the first (header) row of every joined file
            SpreadsheetJoinOptions joinOptions = new SpreadsheetJoinOptions
            {
                Mode = SpreadsheetJoinMode.Rows,
                SkipRows = 1
            };

            // Load the source XLSX file
            using (Merger merger = new Merger(Constants.SAMPLE_XLSX))
            {
                // Append the rows of another XLSX file
                merger.Join(Constants.SAMPLE_XLSX_2, joinOptions);
                // Save the result
                merger.Save(outputFile);
            }

            Console.WriteLine("\nSpreadsheet rows merge completed successfully. \nCheck output in {0}", outputFolder);
        }
    }
}
