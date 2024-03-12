﻿using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to set license from stream.
    /// </summary>
    public class SetLicenseFromStream
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Quick Start: SetLicenseFromStream");
            Console.WriteLine();

            if (File.Exists(Constants.LicensePath))
            {
                using (FileStream stream = File.OpenRead(Constants.LicensePath))
                {
                    License license = new License();
                    license.SetLicense(stream);
                    Constants.IsLicensed = true;
                }

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