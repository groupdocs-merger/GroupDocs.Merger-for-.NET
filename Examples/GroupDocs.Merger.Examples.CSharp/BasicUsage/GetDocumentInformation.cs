using System;
using GroupDocs.Merger.Domain.Result;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to get document info.
    /// </summary>
    public class GetDocumentInformation
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: GetDocumentInformation");
            Console.WriteLine();

            using (Merger merger = new Merger(Constants.SAMPLE_VSDX))
            {
                IDocumentInfo info = merger.GetDocumentInfo();
                Console.WriteLine(info);
            }

            Console.WriteLine("Document info retrieved successfully.");
        }
    }
}