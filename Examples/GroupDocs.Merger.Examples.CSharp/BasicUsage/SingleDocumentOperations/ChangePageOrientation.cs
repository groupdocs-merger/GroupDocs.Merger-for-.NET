using System;
using System.IO;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to change document page orientation.
    /// </summary>
    public class ChangePageOrientation
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_DOCX;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            OrientationOptions orientationOptions = new OrientationOptions(OrientationMode.Landscape, new int[] { 3, 4 });

            using (Merger merger = new Merger(filePath))
            {
                merger.ChangeOrientation(orientationOptions);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Source document changed orientation successfully.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}