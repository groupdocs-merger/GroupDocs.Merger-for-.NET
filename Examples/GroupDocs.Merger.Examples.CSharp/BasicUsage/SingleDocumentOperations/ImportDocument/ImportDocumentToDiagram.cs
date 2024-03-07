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
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: ImportDocumentToDiagram");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_VSDX;
            string imageFilePath = Constants.SAMPLE_EMF;
            string embeddedFilePath = Constants.SAMPLE_PPTX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            FileStream imageStream = new FileStream(imageFilePath, FileMode.Open);
            byte[] imageBytes = ExampleHelper.ToBytes(imageStream);
            imageStream.Close();

            OleDiagramOptions oleDiagramOptions = new OleDiagramOptions(embeddedFilePath, imageBytes, 2);
            oleDiagramOptions.X = 1;
            oleDiagramOptions.Y = 1;
            oleDiagramOptions.Width = 2;
            oleDiagramOptions.Height = 1;

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