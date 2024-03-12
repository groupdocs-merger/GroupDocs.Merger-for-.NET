﻿using System;

namespace GroupDocs.Merger.Examples.CSharp.QuickStart
{
    /// <summary>
    /// This example demonstrates how to set Metered license.
    /// Learn more about Metered license at https://purchase.groupdocs.com/faqs/licensing/metered.
    /// </summary>
    public class SetMeteredLicense
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Quick Start: SetMeteredLicense");
            Console.WriteLine();

            string publicKey = "*****";
            string privateKey = "*****";

            Metered metered = new Metered();
            metered.SetMeteredKey(publicKey, privateKey);
            Constants.IsLicensed = true;

            Console.WriteLine("License set successfully.");
        }
    }
}