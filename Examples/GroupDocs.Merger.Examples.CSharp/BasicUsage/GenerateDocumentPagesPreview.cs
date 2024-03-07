using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    public class GenerateDocumentPagesPreview
    {
        /// <summary>
        /// This example demonstrates how to generate document pages preview.
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: GenerateDocumentPagesPreview");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_XLSX;

            using (Merger merger = new Merger(filePath))
            {
                PreviewOptions previewOption = new PreviewOptions(CreatePageStream, ReleasePageStream, PreviewMode.JPEG);
                merger.GeneratePreview(previewOption);
            }
        }

        private static string GetImagePath(int pageNumber)
        {
            return Path.Combine(Constants.OutputPath, "GeneratePreview", $"image-{pageNumber}.jpg");
        }

        private static Stream CreatePageStream(int pageNumber)
        {
            string imageFilePath = GenerateDocumentPagesPreview.GetImagePath(pageNumber);

            var folder = Path.GetDirectoryName(imageFilePath);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            return new FileStream(imageFilePath, FileMode.Create);
        }

        private static void ReleasePageStream(int pageNumber, Stream pageStream)
        {
            pageStream.Dispose();

            string imageFilePath = GenerateDocumentPagesPreview.GetImagePath(pageNumber);
            Console.WriteLine("Image file '{0}' is ready for preview.", imageFilePath);
        }
    }
}