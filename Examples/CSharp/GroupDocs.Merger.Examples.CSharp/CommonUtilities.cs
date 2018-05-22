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
        public const string licensePath = "../../../../Data/Storage/GroupDocs.Total.lic";
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
    }
}
