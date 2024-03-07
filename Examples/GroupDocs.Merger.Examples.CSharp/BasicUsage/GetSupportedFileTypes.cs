using System;
using System.Collections.Generic;
using System.Linq;
using GroupDocs.Merger.Domain;

namespace GroupDocs.Merger.Examples.CSharp.BasicUsage
{
    /// <summary>
    /// This example demonstrates how to obtain all supported file types.
    /// </summary>
    public class GetSupportedFileTypes
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Basic Usage: GetSupportedFileTypes");
            Console.WriteLine();

            IEnumerable<FileType> fileTypes = FileType
                    .GetSupportedFileTypes()
                    .OrderBy(fileType => fileType.Extension);

            foreach (FileType fileType in fileTypes)
            {
                Console.WriteLine(fileType);
            }

            Console.WriteLine("Supported file types retrieved successfully.");
        }
    }
}