using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Merger.Examples.CSharp
{
    internal static class Constants
    {
        public static bool IsLicensed = false;

        public const string LicensePath = "./Resources/GroupDocs.Merger.lic";        
        
        public const string SamplesPath = @"./Resources/SampleFiles";
        public const string OutputPath = @"./Results/Output";

        // Common
        public const string SAMPLE_NAME = "Sample";
        public const string SAMPLE_PASSWORD = "SomePasswordString";

        // Text
        public static string SAMPLE_TXT =>
            GetSampleFilePath(Path.Combine("Text", "sample.txt"));

        // Diagrams
        public static string SAMPLE_VSDX =>
            GetSampleFilePath(Path.Combine("Diagram", "sample.vsdx"));

        // PDFs
        public static string SAMPLE_PDF_PROTECTED =>
            GetSampleFilePath(Path.Combine("Pdf", "sample_protected.pdf"));
        public static string SAMPLE_PDF =>
            GetSampleFilePath(Path.Combine("Pdf", "sample.pdf"));
        public static string SAMPLE_PDF_2 =>
            GetSampleFilePath(Path.Combine("Pdf", "sample_simple.pdf"));
        

        // Presentations
        public static string SAMPLE_PPTX_PROTECTED =>
            GetSampleFilePath(Path.Combine("Presentation", "sample_protected.pptx"));
        public static string SAMPLE_PPTX =>
            GetSampleFilePath(Path.Combine("Presentation", "sample.pptx"));

        // Spreadsheets
        public static string SAMPLE_XLSX_PROTECTED =>
            GetSampleFilePath(Path.Combine("Spreadsheet", "sample_protected.xlsx"));
        public static string SAMPLE_XLSX =>
            GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsx"));

        // Word Processing documents
        public static string SAMPLE_DOCX_PROTECTED =>
            GetSampleFilePath(Path.Combine("WordProcessing", "sample_protected.docx"));
        public static string SAMPLE_DOCX =>
            GetSampleFilePath(Path.Combine("WordProcessing", "sample.docx"));
        public static string SAMPLE_DOCX_2 =>
           GetSampleFilePath(Path.Combine("WordProcessing", "sample2.docx"));
        public static string SAMPLE_DOCX_3 =>
           GetSampleFilePath(Path.Combine("WordProcessing", "sample3.docx"));
        public static string SAMPLE_DOCX_4 =>
           GetSampleFilePath(Path.Combine("WordProcessing", "sample4.docx"));
        public static string SAMPLE_DOCX_10_PAGES =>
           GetSampleFilePath(Path.Combine("WordProcessing", "sample-10-pages.docx"));
            
        // Note documents
        public static string SAMPLE_ONE_PROTECTED =>
            GetSampleFilePath(Path.Combine("Note", "sample_protected.one"));
        public static string SAMPLE_ONE =>
            GetSampleFilePath(Path.Combine("Note", "sample.one"));

        // Images
        public static string SAMPLE_EMF =>
            GetSampleFilePath(Path.Combine("Image", "sample.emf"));
        public static string SAMPLE_PNG =>
            GetSampleFilePath(Path.Combine("Image", "sample1.png"));
        public static string SAMPLE_BMP =>
            GetSampleFilePath(Path.Combine("Image", "sample2.bmp"));
        public static string SAMPLE_TIFF =>
            GetSampleFilePath(Path.Combine("Image", "sample3.tiff"));

        private static string GetSampleFilePath(string filePath) =>
            Path.Combine(SamplesPath, filePath);

        public static string GetOutputDirectoryPath([CallerFilePath] string callerFilePath = null)
        {
            string outputDirectory = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(callerFilePath));

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            string path = Path.GetFullPath(outputDirectory);
            return path;
        }
    }
}