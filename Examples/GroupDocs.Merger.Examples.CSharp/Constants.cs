using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Merger.Examples.CSharp
{
    internal static class Constants
    {
        public const string LicensePath = "C:\\licenses\\GroupDocs.Merger.lic";
        public const string SamplesPath = "..\\..\\..\\..\\Resources\\SampleFiles";
        public const string OutputPath = "..\\..\\..\\Output\\";

        // Common
        public const string SAMPLE_NAME = "Sample";
        public const string SAMPLE_PASSWORD = "SomePasswordString";

        // Text
        public static string SAMPLE_TXT =>
            GetSampleFilePath("Text\\sample.txt");

        // Diagrams
        public static string SAMPLE_VSDX =>
            GetSampleFilePath("Diagram\\sample.vsdx");

        // PDFs
        public static string SAMPLE_PDF_PROTECTED =>
            GetSampleFilePath("Pdf\\sample_protected.pdf");
        public static string SAMPLE_PDF =>
            GetSampleFilePath("Pdf\\sample.pdf");
        public static string SAMPLE_PDF_2 =>
            GetSampleFilePath("Pdf\\sample_simple.pdf");
        

        // Presentations
        public static string SAMPLE_PPTX_PROTECTED =>
            GetSampleFilePath("Presentation\\sample_protected.pptx");
        public static string SAMPLE_PPTX =>
            GetSampleFilePath("Presentation\\sample.pptx");

        // Spreadsheets
        public static string SAMPLE_XLSX_PROTECTED =>
            GetSampleFilePath("Spreadsheet\\sample_protected.xlsx");
        public static string SAMPLE_XLSX =>
            GetSampleFilePath("Spreadsheet\\sample.xlsx");

        // Word Processing documents
        public static string SAMPLE_DOCX_PROTECTED =>
            GetSampleFilePath("WordProcessing\\sample_protected.docx");
        public static string SAMPLE_DOCX =>
            GetSampleFilePath("WordProcessing\\sample.docx");
        public static string SAMPLE_DOCX_2 =>
           GetSampleFilePath("WordProcessing\\sample2.docx");
        public static string SAMPLE_DOCX_3 =>
           GetSampleFilePath("WordProcessing\\sample3.docx");
        public static string SAMPLE_DOCX_4 =>
           GetSampleFilePath("WordProcessing\\sample4.docx");
        public static string SAMPLE_DOCX_10_PAGES =>
           GetSampleFilePath("WordProcessing\\sample-10-pages.docx");

        // Note documents
        public static string SAMPLE_ONE_PROTECTED =>
            GetSampleFilePath("Note\\sample_protected.one");
        public static string SAMPLE_ONE =>
            GetSampleFilePath("Note\\sample.one");

        // Images
        public static string SAMPLE_PNG =>
            GetSampleFilePath("Image\\example1.png");
        public static string SAMPLE_BMP =>
            GetSampleFilePath("Image\\example2.bmp");
        public static string SAMPLE_TIFF =>
            GetSampleFilePath("Image\\example3.tiff");

        private static string GetSampleFilePath(string filePath) =>
            Path.Combine(SamplesPath, filePath);

        public static string GetOutputDirectoryPath([CallerFilePath] string callerFilePath = null)
        {
            string outputDirectory = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(callerFilePath));

            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            return outputDirectory;
        }
    }
}