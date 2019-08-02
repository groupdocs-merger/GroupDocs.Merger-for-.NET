using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Format;
using GroupDocs.Merger.Domain.Options;
using GroupDocs.Merger.Handler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Merger.Examples.CSharp
{
    public class CommonUtilities
    {
        //ExStart:CommonProperties 
        public const string sourcePath = "../../../../Data/Storage/";
        public const string fileOne = "../../../../Data/Storage/";
        public const string fileTwo = "../../../../Data/Storage/";
        public const string outputPath = "../../../../Data/Output/";
        public const string licensePath = "E://GroupDocs.Total.lic";
        //ExEnd:CommonProperties

        /// <summary>
        /// Loads license from file
        /// </summary>
        public static void LoadLicenseFromFile()
        {
            //ExStart:LoadLicenseFromFile
            try
            {
                // Setup license
                License lic = new License();
                lic.SetLicense(licensePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:LoadLicenseFromFile
        }

        /// <summary>
        /// Loads license from stream object
        /// </summary>
        public static void LoadLicenseFromStream()
        {
            //ExStart:LoadLicenseFromStream
            try
            {
                // Obtain license stream
                FileStream licenseStream = new FileStream(licensePath, FileMode.Open);

                // Setup license
                GroupDocs.Merger.License lic = new GroupDocs.Merger.License();
                lic.SetLicense(licenseStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:LoadLicenseFromStream
        }

        /// <summary>
        /// Metered licensing
        /// </summary>
        public static void MeteredLicense()
        {
            //ExStart:MeteredLicense
            try
            {
                string PublicKey = ""; // Your public license key
                string PrivateKey = ""; // Your private license key
                Metered metered = new Metered();
                metered.SetMeteredKey(PublicKey, PrivateKey);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:MeteredLicense
        }
        public static void GetSupportedFormats()
        {
            //ExStart:GetSupportedFormats
            Dictionary<string, FileFormat> documentFormatsContainer = new DocumentHandler().GetSupportedFormats();
            foreach (KeyValuePair<string, FileFormat> item in documentFormatsContainer)
            {
                Console.WriteLine("Key: {0}, format: {1}", item.Key, item.Value);
            }
            //ExEnd:GetSupportedFormats
        }

        public static void GetDocumentInformation(string fileName)
        {
            //ExStart:GetDocumentInformation
            DocumentHandler handler = new DocumentHandler();
            string sourceFile = CommonUtilities.sourcePath + fileName;
            string password = "somepassword";
            Stream openSourceFile = new FileStream(sourceFile, FileMode.Open);
            
            // Get information about document
            DocumentInfo resultInfo = handler.GetDocumentInfo(openSourceFile);

            // Get information about password protected document.
            DocumentInfo docInfo = new DocumentHandler().GetDocumentInfo(openSourceFile, password);

            Console.WriteLine("Size: {0}, Pages: {1}", resultInfo.Size, resultInfo.Pages);
            //ExEnd:GetDocumentInformation
        }
    }
}
