using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Format;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.Domain.Result;
using GroupDocs.Merger.Domain.Security;
using GroupDocs.Merger.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Merger.Examples.CSharp
{
    public class DocsManipulation
    {
        /// <summary>
        /// Change page order for password-protected document of known format (fastest version)
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void ChangePageOrderOfProtectedKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrderOfProtectedKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            //Set password, as document is password protected
            string password = "somepassword";
            int pageNumber = 4;
            int newPageNumber = 2;

            MoveOptions pageOptions = new MoveOptions(FileFormat.Docx, password, pageNumber, newPageNumber);
            Stream openSourceFile = new FileStream(sourceFile, FileMode.Open);

            DocumentResult result = new DocumentHandler().MovePage(openSourceFile, pageOptions);

            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Docx);
            Stream documentStream = result.Stream;
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrderOfProtectedKnownFormatDoc
        }

        /// <summary>
        /// Change page order for document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void ChangePageOrderUnKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrderUnKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;

            int pageNumber = 6;
            int newPageNumber = 1;
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().MovePage(openFile, pageNumber, newPageNumber);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrderUnKnownFormatDoc
        }

        /// <summary>
        /// Remove list of pages from password-protected document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemovePagesFromProtectedKnownFormatDoc(string fileName)
        {
            //ExStart:RemovePagesFromProtectedKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            //Set password, as document is password protected
            string password = "somepassword";
            List<int> pages = new List<int>();

            pages.Add(2);
            RemovePagesOptions pagesOptions = new RemovePagesOptions(FileFormat.Xlsx, password, pages);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            DocumentResult result = new DocumentHandler().RemovePages(openFile, pagesOptions);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Xlsx);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemovePagesFromProtectedKnownFormatDoc
        }

        /// <summary>
        /// Remove list of pages from document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemovePagesFromUnknownFormatDoc(string fileName)
        {
            //ExStart:RemovePagesFromUnknownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            List<int> pages = new List<int>();
            pages.Add(2);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RemovePages(openFile, pages);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemovePagesFromUnknownFormatDoc
        }

        /// <summary>
        /// Remove range of pages from password-protected document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemovePagesRangeFromProtectedKnownFormatDoc(string fileName)
        {
            //ExStart:RemovePagesRangeFromProtectedKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "";
            int startPage = 2;
            int endPage = 4;
            RangeMode mode = RangeMode.AllPages;
            RemovePagesOptions rangeOptions = new RemovePagesOptions(FileFormat.Docx, password,startPage, endPage, mode);
            
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RemovePages(openFile, rangeOptions);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Docx);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemovePagesRangeFromProtectedKnownFormatDoc
        }

        /// <summary>
        /// Remove range of pages from document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemovePagesRangeFromUnknownFormatDoc(string fileName)
        {
            //ExStart:RemovePagesRangeFromUnknownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            int startPage = 1;
            int endPage = 5;
            RangeMode mode = RangeMode.AllPages;
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RemovePages(openFile, startPage, endPage, mode);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemovePagesRangeFromUnknownFormatDoc
        }

        /// <summary>
        /// Splitting by page numbers to several one page documents 
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SplittingToOnePageDocuments(string fileName)
        {
            //ExStart:SplittingToOnePageDocuments
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            List<int> pages = new List<int>();
            pages.Add(3);
            pages.Add(4);
            SplitOptions splitOptions = new SplitOptions(FileFormat.Pdf, password, pages);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            MultiDocumentResult splitResult = new DocumentHandler().Split(openFile, splitOptions);
            for (int i = 0; i < splitResult.Documents.Count; i++)
            {
                // First document 
                Stream documentStream = splitResult.Documents[i].Stream;
                //output file
                var fileStream = File.Create(CommonUtilities.outputPath + "OutPut " + i + "." + FileFormat.Pdf);
                documentStream.CopyTo(fileStream);
                documentStream.Close();
            }
            //ExEnd:SplittingToOnePageDocuments
        }

        /// <summary>
        /// Splitting  by page ranges to several documents
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SplittingByPageRanges(string fileName)
        {
            //ExStart:SplittingByPageRanges
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            int startPage = 5;
            int endPage = 8;
            RangeMode mode = RangeMode.EvenPages;
            SplitOptions splitOptions = new SplitOptions(FileFormat.Pdf, password,startPage, endPage, mode);
           
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            MultiDocumentResult splitResult = new DocumentHandler().Split(openFile, splitOptions);
            for (int i = 0; i < splitResult.Documents.Count; i++)
            {
                Stream documentStream = splitResult.Documents[i].Stream;
                //output file
                var fileStream = File.Create(CommonUtilities.outputPath + "OutPut " + i + "." + FileFormat.Pdf);
                documentStream.CopyTo(fileStream);
                documentStream.Close();
            }
            //ExEnd:SplittingByPageRanges
        }

        /// <summary>
        /// Swap by page numbers for password-protected document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SwapProtectedDocumentOfKnownFormat(string fileName)
        {
            //ExStart:SwapProtectedDocumentOfKnownFormat
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            int pageNumber1 = 3;
            int pageNumber2 = 6;
            SwapOptions pagesOptions = new SwapOptions(pageNumber2, pageNumber1, FileFormat.Pdf, password);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().SwapPages(openFile, pagesOptions);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Pdf);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:SwapProtectedDocumentOfKnownFormat
        }

        /// <summary>
        /// Swap by page numbers for document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SwapDocumentOfUnknownFormat(string fileName)
        {
            //ExStart:SwapDocumentOfUnknownFormat
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            int pageNumber1 = 3;
            int pageNumber2 = 6;
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().SwapPages(openFile, pageNumber1, pageNumber2);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:SwapDocumentOfUnknownFormat
        }

        /// <summary>
        /// Trim document of known format by page numbers list 
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void TrimDocumentByPageNumList(string fileName)
        {
            //ExStart:TrimDocumentKnownFormat
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparation.
            string password = "SomePasswordString";
            int pageNumber1 = 3;
            int pageNumber2 = 6;
            List<int> pages = new List<int>();
            pages.Add(pageNumber1);
            pages.Add(pageNumber2);
            TrimOptions trimOptions = new TrimOptions(FileFormat.Pdf, password, pages);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().Trim(openFile, trimOptions);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Pdf);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:TrimDocumentKnownFormat
        }

        /// <summary>
        /// Trim document of known format by page numbers range
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void TrimDocumentByPageNumRange(string fileName)
        {
            //ExStart:TrimDocumentUnknownFormat
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparation.
            string password = "SomePasswordString";
            int startPage = 1;
            int endPage = 5;
            RangeMode mode = RangeMode.AllPages;
            TrimOptions trimOptions = new TrimOptions(FileFormat.Pdf, password,startPage, endPage, mode);
           
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().Trim(openFile, trimOptions);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Pdf);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:TrimDocumentUnknownFormat
        }

        /// <summary>
        /// Join list of password-protected document of known format
        /// </summary>
        /// <param name="fileOne">first source file</param>
        /// <param name="fileTwo">second source file</param>
        public static void JoinDocumentsOfKnownFormat(string fileOne, string fileTwo)
        {
            //ExStart:JoinDocumentsOfKnownFormat
            string sourceFile1 = CommonUtilities.fileOne + fileOne;
            string sourceFile2 = CommonUtilities.fileTwo + fileTwo;

            // Preparing.
            string password = "SomePasswordString";
            Stream openFile1 = new FileStream(sourceFile1, FileMode.Open);
            Stream openFile2 = new FileStream(sourceFile2, FileMode.Open);
            List<JoinItem> documentStreams = new List<JoinItem>();
            JoinItem item1 = new JoinItem(openFile1, FileFormat.Docx, password);
            documentStreams.Add(item1);
            JoinItem item2 = new JoinItem(openFile2, FileFormat.Docx, password);
            documentStreams.Add(item2);

            // Main method.
            DocumentResult result = new DocumentHandler().Join(documentStreams);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Docx);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:JoinDocumentsOfKnownFormat
        }

        /// <summary>
        /// Join list of document of unknown format
        /// </summary>
        /// <param name="fileOne">first source file</param>
        /// <param name="fileTwo">second source file</param>
        public static void JoinDocumentsOfUnknownFormat(string fileOne, string fileTwo)
        {
            //ExStart:JoinDocumentsOfUnknownFormat
            string sourceFile1 = CommonUtilities.fileOne + fileOne;
            string sourceFile2 = CommonUtilities.fileTwo + fileTwo;

            // Preparing.
            Stream openFile1 = new FileStream(sourceFile1, FileMode.Open);
            Stream openFile2 = new FileStream(sourceFile2, FileMode.Open);
            List<Stream> documentStreams = new List<Stream>();
            documentStreams.Add(openFile1);
            documentStreams.Add(openFile2);


            // Main method.
            DocumentResult result = new DocumentHandler().Join(documentStreams);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:JoinDocumentsOfUnknownFormat
        }

        /// <summary>
        /// Check document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void CheckProtectionOfKnownFormatDoc(string fileName)
        {
            //ExStart:CheckProtectionOfKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Check document of known format
            bool resultProtected = new DocumentHandler().IsPasswordSet(openFile, FileFormat.Docx);
            Console.WriteLine(resultProtected);
            //ExEnd:CheckProtectionOfKnownFormatDoc
        }

        /// <summary>
        /// Check document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void CheckProtectionOfUnknownFormatDoc(string fileName)
        {
            //ExStart:CheckProtectionOfUnknownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Check document of known format
            bool resultProtected = new DocumentHandler().IsPasswordSet(openFile);
            Console.WriteLine(resultProtected);
            //ExEnd:CheckProtectionOfUnknownFormatDoc
        }

        /// <summary>
        /// Remove password protection for document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemoveProtectionOfKnownFormatDoc(string fileName)
        {
            //ExStart:RemoveProtectionOfKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            RemovePasswordOptions options = new RemovePasswordOptions(FileFormat.Docx, password);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RemovePassword(openFile, options);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Pdf);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemoveProtectionOfKnownFormatDoc
        }

        /// <summary>
        /// Remove password protection for document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RemoveProtectionOfUnknownFormatDoc(string fileName)
        {
            //ExStart:RemoveProtectionOfUnknownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RemovePassword(openFile, password);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Pdf);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:RemoveProtectionOfUnknownFormatDoc
        }

        /// <summary>
        /// Set password protection for document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SetProtectionForKnownFormatDocs(string fileName)
        {
            //ExStart:SetProtectionForKnownFormatDocs
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            AddPasswordOptions options = new AddPasswordOptions(FileFormat.Docx, password);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().AddPassword(openFile, options);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Xlsx);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:SetProtectionForKnownFormatDocs
        }

        /// <summary>
        /// Set password protection for document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void SetProtectionForUnknownFormatDocs(string fileName)
        {
            //ExStart:SetProtectionForUnknownFormatDocs
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string password = "SomePasswordString";
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().AddPassword(openFile, password);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:SetProtectionForUnknownFormatDocs
        }
        /// <summary>
        /// Update password for document of known format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void UpdateProtectionForKnownForamtDocs(string fileName)
        {
            //ExStart:UpdateProtectionForKnownForamtDocs
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string currentPassword = "SomePasswordString";
            string newPassword = "newpass123";
            UpdatePasswordOptions options = new UpdatePasswordOptions(FileFormat.Docx, currentPassword, newPassword);
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().UpdatePassword(openFile, options);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Docx);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:UpdateProtectionForKnownForamtDocs
        }

        /// <summary>
        /// Update password for document of unknown format
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void UpdateProtectionForUnknownForamtDocs(string fileName)
        {
            //ExStart:UpdateProtectionForUnknownForamtDocs
            string sourceFile = CommonUtilities.sourcePath + fileName;
            // Preparing.
            string currentPassword = "SomePasswordString";
            string newPassword = "NewPasswordString";
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().UpdatePassword(openFile, currentPassword, newPassword);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:UpdateProtectionForUnknownForamtDocs
        }

        /// <summary>
        /// Change page orientation of known formatted docs
        /// </summary>
        /// <param name="fileName">source file name</param>
        public static void ChangePageOrientationOfProtectedKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrientationOfProtectedKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            //Set password, as document is password protected
            string password = "somepassword";
            OrientationOptions pagesOptions = new OrientationOptions(OrientationMode.Landscape, FileFormat.Docx, password, new[] { 1, 2 });
            Stream documentExample = new FileStream(sourceFile, FileMode.Open);


            // Main method.
            DocumentResult result = new DocumentHandler().ChangeOrientation(documentExample, pagesOptions);
            Stream documentStream = result.Stream; 
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrientationOfProtectedKnownFormatDoc
        }

         /// <summary>
         /// change page orientation of unknown formatted docs
         /// </summary>
         /// <param name="fileName">source file</param>
        public static void ChangePageOrientationUnKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrientationUnKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName; 
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().ChangeOrientation(openFile, OrientationMode.Landscape, new[] { 1, 2 });
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrientationUnKnownFormatDoc
        }





        /// <summary>
        /// Rotate pages of known formatted docs
        /// </summary>
        /// <param name="fileName">source file name</param>
        public static void RotatePagesOfProtectedKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrientationOfProtectedKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            //Set password, as document is password protected
            string password = "somepassword";

            RotateOptions pagesOptions = new RotateOptions(FileFormat.Pdf, password, RotateMode.Rotate180, new List<int> { 1, 2 });
            Stream documentExample = new FileStream(sourceFile, FileMode.Open);

            // Main method.
            DocumentResult result = new DocumentHandler().RotatePages(documentExample, pagesOptions);
            Stream documentStream = result.Stream;
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrientationOfProtectedKnownFormatDoc
        }

        /// <summary>
        /// Rotate pages of unknown formatted docs
        /// </summary>
        /// <param name="fileName">source file</param>
        public static void RotatePagesUnKnownFormatDoc(string fileName)
        {
            //ExStart:ChangePageOrientationUnKnownFormatDoc
            string sourceFile = CommonUtilities.sourcePath + fileName;
            Stream openFile = new FileStream(sourceFile, FileMode.Open);

            DocumentResult result = new DocumentHandler().RotatePages(openFile, RotateMode.Rotate270);
            Stream documentStream = result.Stream;
            //output file
            var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + result.FileFormat);
            documentStream.CopyTo(fileStream);
            documentStream.Close();
            //ExEnd:ChangePageOrientationUnKnownFormatDoc
        } 
    }
}