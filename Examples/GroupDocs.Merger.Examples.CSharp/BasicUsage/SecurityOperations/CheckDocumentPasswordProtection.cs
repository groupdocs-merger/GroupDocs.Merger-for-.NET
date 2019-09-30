using System;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to check document password.
    /// </summary>
    public class CheckDocumentPasswordProtection
    {
        public static void Run()
        {
            string filePath = Constants.SAMPLE_XLSX_PROTECTED;                                   
            bool isPasswordSet = false;

            using (Merger merger = new Merger(filePath))
            {
                isPasswordSet = merger.IsPasswordSet();
            }

            Console.WriteLine($"Source document password has password: {isPasswordSet}.");            
        }
    }
}