using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to load external resources only from trusted locations,
    /// listed in WhitelistedResources as absolute URI prefixes.
    /// </summary>
    public class LoadExternalResourcesFromTrustedLocations
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Advanced Usage: LoadExternalResourcesFromTrustedLocations");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_HTML_WITH_EXTERNAL_RESOURCES;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            LoadOptions loadOptions = new LoadOptions(FileType.HTML)
            {
                WhitelistedResources = new List<string>
                {
                    "https://raw.githubusercontent.com/groupdocs/groupdocs.github.io/master/img/"
                }
            };

            using (Merger merger = new Merger(filePath, loadOptions))
            {
                merger.Join(Constants.SAMPLE_HTML);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Documents joined with resources from trusted locations only.");
            Console.WriteLine($"Check output {filePathOut}.");
        }
    }
}
