using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Merger.Examples.CSharp
{
    internal static class Constants
    {
        public static bool IsLicensed = false;

        public const string LicensePath = "./Resources/GroupDocs.Merger.NET.lic";
        
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
        public static string SAMPLE_GIF =>
            GetSampleFilePath(Path.Combine("Image", "sample.gif"));
        public static string SAMPLE_PNG =>
            GetSampleFilePath(Path.Combine("Image", "sample1.png"));
        public static string SAMPLE_BMP =>
            GetSampleFilePath(Path.Combine("Image", "sample2.bmp"));
        public static string SAMPLE_TIFF =>
            GetSampleFilePath(Path.Combine("Image", "sample3.tiff"));
        public static string SAMPLE_TIF =>
            GetSampleFilePath(Path.Combine("Image", "sample4.tif"));
        public static string SAMPLE_JPG =>
            GetSampleFilePath(Path.Combine("Image", "sample5.jpg"));
        public static string SAMPLE_SVG =>
            GetSampleFilePath(Path.Combine("Image", "sample.svg"));
        public static string SAMPLE_SVGZ =>
            GetSampleFilePath(Path.Combine("Image", "sample.svgz"));

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


        // CSV
        public static string SAMPLE_CSV => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.csv"));
        public static string SAMPLE_CSV_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.csv"));

        // DOC
        public static string SAMPLE_DOC => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.doc"));
        public static string SAMPLE_DOC_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.doc"));

        // DOCM
        public static string SAMPLE_DOCM => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.docm"));
        public static string SAMPLE_DOCM_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.docm"));

        // DOT
        public static string SAMPLE_DOT => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dot"));
        public static string SAMPLE_DOT_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dot"));

        // DOTM
        public static string SAMPLE_DOTM => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dotm"));
        public static string SAMPLE_DOTM_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dotm"));

        // DOTX
        public static string SAMPLE_DOTX => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dotx"));
        public static string SAMPLE_DOTX_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.dotx"));

        // EPUB
        public static string SAMPLE_EPUB => GetSampleFilePath(Path.Combine("Ebook", "sample.epub"));
        public static string SAMPLE_EPUB_2 => GetSampleFilePath(Path.Combine("Ebook", "sample.epub"));

        // HTML
        public static string SAMPLE_HTML => GetSampleFilePath(Path.Combine("Web", "sample.html"));
        public static string SAMPLE_HTML_2 => GetSampleFilePath(Path.Combine("Web", "sample.html"));

        // MHT
        public static string SAMPLE_MHT => GetSampleFilePath(Path.Combine("Web", "sample.mht"));
        public static string SAMPLE_MHT_2 => GetSampleFilePath(Path.Combine("Web", "sample.mht"));

        // MHTML
        public static string SAMPLE_MHTML => GetSampleFilePath(Path.Combine("Web", "sample.mhtml"));
        public static string SAMPLE_MHTML_2 => GetSampleFilePath(Path.Combine("Web", "sample.mhtml"));

        // ODP
        public static string SAMPLE_ODP => GetSampleFilePath(Path.Combine("Presentation", "sample.odp"));
        public static string SAMPLE_ODP_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.odp"));

        // ODS
        public static string SAMPLE_ODS => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.ods"));
        public static string SAMPLE_ODS_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.ods"));

        // ODT
        public static string SAMPLE_ODT => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.odt"));
        public static string SAMPLE_ODT_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.odt"));

        // ONE
        public static string SAMPLE_ONE_2 => GetSampleFilePath(Path.Combine("Note", "sample.one"));

        // OTP
        public static string SAMPLE_OTP => GetSampleFilePath(Path.Combine("Presentation", "sample.otp"));
        public static string SAMPLE_OTP_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.otp"));

        // OTT
        public static string SAMPLE_OTT => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.ott"));
        public static string SAMPLE_OTT_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.ott"));
        
        // PPS
        public static string SAMPLE_PPS => GetSampleFilePath(Path.Combine("Presentation", "sample.pps"));
        public static string SAMPLE_PPS_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.pps"));

        // PPSX
        public static string SAMPLE_PPSX => GetSampleFilePath(Path.Combine("Presentation", "sample.ppsx"));
        public static string SAMPLE_PPSX_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.ppsx"));

        // PPT
        public static string SAMPLE_PPT => GetSampleFilePath(Path.Combine("Presentation", "sample.ppt"));
        public static string SAMPLE_PPT_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.ppt"));

        // PPTX
        public static string SAMPLE_PPTX_2 => GetSampleFilePath(Path.Combine("Presentation", "sample.pptx"));

        // RTF
        public static string SAMPLE_RTF => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.rtf"));
        public static string SAMPLE_RTF_2 => GetSampleFilePath(Path.Combine("Wordprocessing", "sample.rtf"));

        // TEX
        public static string SAMPLE_TEX => GetSampleFilePath(Path.Combine("PageDescriptionLanguage", "sample.tex"));
        public static string SAMPLE_TEX_2 => GetSampleFilePath(Path.Combine("PageDescriptionLanguage", "sample.tex"));

        // TSV
        public static string SAMPLE_TSV => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.tsv"));
        public static string SAMPLE_TSV_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.tsv"));

        // TXT
        public static string SAMPLE_TXT_2 => GetSampleFilePath(Path.Combine("Text", "sample.txt"));

        // VDX
        public static string SAMPLE_VDX => GetSampleFilePath(Path.Combine("Diagram", "sample.vdx"));
        public static string SAMPLE_VDX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vdx"));

        // VSDM
        public static string SAMPLE_VSDM => GetSampleFilePath(Path.Combine("Diagram", "sample.vsdm"));
        public static string SAMPLE_VSDM_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vsdm"));

        // VSDX
        public static string SAMPLE_VSDX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vsdx"));

        // VSSM
        public static string SAMPLE_VSSM => GetSampleFilePath(Path.Combine("Diagram", "sample.vssm"));
        public static string SAMPLE_VSSM_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vssm"));

        // VSSX
        public static string SAMPLE_VSSX => GetSampleFilePath(Path.Combine("Diagram", "sample.vssx"));
        public static string SAMPLE_VSSX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vssx"));

        // VSTM
        public static string SAMPLE_VSTM => GetSampleFilePath(Path.Combine("Diagram", "sample.vstm"));
        public static string SAMPLE_VSTM_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vstm"));

        // VSTX
        public static string SAMPLE_VSTX => GetSampleFilePath(Path.Combine("Diagram", "sample.vstx"));
        public static string SAMPLE_VSTX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vstx"));

        // VSX
        public static string SAMPLE_VSX => GetSampleFilePath(Path.Combine("Diagram", "sample.vsx"));
        public static string SAMPLE_VSX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vsx"));

        // VTX
        public static string SAMPLE_VTX => GetSampleFilePath(Path.Combine("Diagram", "sample.vtx"));
        public static string SAMPLE_VTX_2 => GetSampleFilePath(Path.Combine("Diagram", "sample.vtx"));

        // XLAM
        public static string SAMPLE_XLAM => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlam"));
        public static string SAMPLE_XLAM_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlam"));

        // XLS
        public static string SAMPLE_XLS => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xls"));
        public static string SAMPLE_XLS_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xls"));

        // XLSB
        public static string SAMPLE_XLSB => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsb"));
        public static string SAMPLE_XLSB_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsb"));

        // XLSM
        public static string SAMPLE_XLSM => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsm"));
        public static string SAMPLE_XLSM_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsm"));

        // XLSX
        public static string SAMPLE_XLSX_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlsx"));

        // XLT
        public static string SAMPLE_XLT => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlt"));
        public static string SAMPLE_XLT_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xlt"));

        // XLTM
        public static string SAMPLE_XLTM => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xltm"));
        public static string SAMPLE_XLTM_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xltm"));

        // XLTX
        public static string SAMPLE_XLTX => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xltx"));
        public static string SAMPLE_XLTX_2 => GetSampleFilePath(Path.Combine("Spreadsheet", "sample.xltx"));

        // XPS
        public static string SAMPLE_XPS => GetSampleFilePath(Path.Combine("PageDescriptionLanguage", "sample.xps"));
        public static string SAMPLE_XPS_2 => GetSampleFilePath(Path.Combine("PageDescriptionLanguage", "sample.xps"));

        // ARCHIVE
        public static string SAMPLE_ZIP => GetSampleFilePath(Path.Combine("Archive", "sample.zip"));
        public static string SAMPLE_TAR => GetSampleFilePath(Path.Combine("Archive", "sample.tar"));
        public static string SAMPLE_RAR => GetSampleFilePath(Path.Combine("Archive", "sample.rar"));
        public static string SAMPLE_7Z => GetSampleFilePath(Path.Combine("Archive", "sample.7z"));

        // AUDIO
        public static string SAMPLE_WAV => GetSampleFilePath(Path.Combine("Audio", "sample.wav"));
        public static string SAMPLE_MP3 => GetSampleFilePath(Path.Combine("Audio", "sample.mp3"));

    }
}