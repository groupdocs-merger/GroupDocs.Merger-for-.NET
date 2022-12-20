﻿using System;
using GroupDocs.Merger.Examples.CSharp.AdvancedUsage;
using GroupDocs.Merger.Examples.CSharp.BasicUsage;
using GroupDocs.Merger.Examples.CSharp.QuickStart;

namespace GroupDocs.Merger.Examples.CSharp
{
    class RunExamples
    {
        static void Main()
        {
            Console.WriteLine("Open RunExamples.cs.");
            Console.WriteLine("Please uncomment the example that you want to run in the Main() method.");
            Console.WriteLine("=====================================================");

            //NOTE: Please uncomment the example that you want to run.
            
            #region Quick Start

            SetLicenseFromFile.Run();
            //SetLicenseFromStream.Run();
            //SetMeteredLicense.Run();

            //HelloWorld.Run();

            #endregion // Quick Start

            #region Basic Usage

            //ImportDocumentToPdf.Run();
            //ImportDocumentToWordProcessing.Run();
            //ImportDocumentToSpreadsheet.Run();
            //ImportDocumentToPresentation.Run();
            //ImportDocumentToDiagram.Run();
           
            #region Get all supported file types
            // GetSupportedFileTypes.Run();
            #endregion

            #region Get info for the selected document
            // GetDocumentInformation.Run();
            #endregion

            #region Generate preview for the selected document
            // GenerateDocumentPagesPreview.Run();
            #endregion

            #region Join files
            // JoinMultipleDocuments.Run();
            // JoinPagesFromVariousDocuments.Run();
            #endregion

            #region Merge files
            MergeCsv.Run();
            MergeDoc.Run();
            MergeDocm.Run();
            MergeDocx.Run();
            MergeDot.Run();
            MergeDotm.Run();
            MergeDotx.Run();
            //MergeEpub.Run();
            MergeHtml.Run();
            MergeMht.Run();
            MergeMhtml.Run();
            MergeOdp.Run();
            MergeOds.Run();
            MergeOdt.Run();
            MergeOne.Run();
            MergeOtp.Run();
            MergeOtt.Run();
            MergePdf.Run();
            MergePps.Run();
            MergePpsx.Run();
            MergePpt.Run();
            MergePptx.Run();
            MergePng.Run();
            MergeBmp.Run();
            MergeTif.Run();
            MergeTiff.Run();
            MergeRtf.Run();
            //MergeTex.Run();
            MergeTsv.Run();
            MergeTxt.Run();
            MergeVdx.Run();
            MergeVsdm.Run();
            MergeVsdx.Run();
            MergeVssm.Run();
            MergeVssx.Run();
            MergeVstm.Run();
            MergeVstx.Run();
            MergeVsx.Run();
            MergeVtx.Run();
            MergeXlam.Run();
            MergeXls.Run();
            MergeXlsb.Run();
            MergeXlsm.Run();
            MergeXlsx.Run();
            MergeXlt.Run();
            MergeXltm.Run();
            MergeXltx.Run();
            MergeXps.Run();
            #endregion

            #region Cross-Join files
            if (Constants.IsLicensed)
            {
                CrossJoinMultipleDocuments.Run();
                CrossJoinMultipleImages.Run();
                CrossJoinPagesFromVariousDocuments.Run();
            }
            #endregion

            #region Split document
            SplitToMultiPageDocuments.Run();
            SplitToSinglePages.Run();
            SplitToSinglePagesByRange.Run();
            SplitToSinglePagesByRangeWithFilter.Run();
            #endregion

            #region Split text file
            SplitToLineRanges.Run();
            SplitToSeparateLines.Run();
            #endregion

            #region Extract document pages 
            ExtractPagesByNumbers.Run();
            ExtractPagesByRange.Run();
            #endregion

            #region Change orientation of the specific document pages
            ChangePageOrientation.Run();
            #endregion

            #region Rotate document pages
            RotatePages.Run();
            #endregion

            #region Swap document pages
            SwapPages.Run();
            #endregion

            #region Remove document pages
            RemovePages.Run();
            #endregion

            #region Move page to a new position within document
            MovePage.Run();
            #endregion

            #region Security - check, add, update, remove document password

            AddDocumentPassword.Run();
            UpdateDocumentPassword.Run();
            CheckDocumentPasswordProtection.Run();
            RemoveDocumentPassword.Run();

            #endregion // Security

            #endregion // Basic usage

            #region Advanced Usage

            #region Loading

            LoadDocumentFromLocalDisk.Run();
            LoadDocumentFromStream.Run();
            //LoadDocumentFromUrl.Run();
            //LoadPasswordProtectedDocument.Run();

            #endregion // Loading

            #endregion // Advanced Usage            

            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("All done.");
            Console.ReadKey();
        }
    }
}