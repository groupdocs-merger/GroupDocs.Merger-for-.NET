using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.Examples.CSharp.Common;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to add attachment to the Diagram document.
    /// </summary>
    public class ImportDocumentToDiagram
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_VSDX;
            string imageFilePath = Constants.SAMPLE_EMF;
            string embeddedFilePath = Constants.SAMPLE_PPTX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            FileStream imageStream = new FileStream(imageFilePath, FileMode.Open);
            byte[] imageBytes = ExampleHelper.ToBytes(imageStream);
            imageStream.Close();

            //TODO: Should be replaced with OleDiagramOptions from GroupDocs.Merger 20.8 !!!
            OleSpreadsheetOptions oleDiagramOptions = new OleSpreadsheetOptions(embeddedFilePath, imageBytes, 1);

            using (Merger merger = new Merger(filePath))
            {
                merger.ImportDocument(oleDiagramOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Embedded object was added to the source document successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}