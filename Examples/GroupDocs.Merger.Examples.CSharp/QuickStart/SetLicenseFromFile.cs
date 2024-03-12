﻿using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to set license from file.
    /// </summary>
    /// <remarks>
    /// The SetLicense method attempts to set a license from several locations relative to the executable and GroupDocs.Merger.dll.
    /// You can also use the additional overload to load a license from a stream, this is useful for instance when the 
    /// License is stored as an embedded resource. 
    /// </remarks>
    public class SetLicenseFromFile
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Quick Start: SetLicenseFromFile");
            Console.WriteLine();

            if (File.Exists(Constants.LicensePath))
            {
                License license = new License();
                license.SetLicense(Constants.LicensePath);
                Constants.IsLicensed = true;

                Console.WriteLine("License set successfully.");
            }
            else
            {
                Console.WriteLine("\nWe do not ship any license with this example. " +
                                  "\nVisit the GroupDocs site to obtain either a temporary or permanent license. " +
                                  "\nLearn more about licensing at https://purchase.groupdocs.com/faqs/licensing. " +
                                  "\nLear how to request temporary license at https://purchase.groupdocs.com/temporary-license.");
            }
        }
    }
}