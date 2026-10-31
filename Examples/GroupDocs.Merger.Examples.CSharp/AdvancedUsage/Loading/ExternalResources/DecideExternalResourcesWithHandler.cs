using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Options;
using System;
using System.IO;

namespace GroupDocs.Merger.Examples.CSharp.AdvancedUsage
{
    /// <summary>
    /// This example demonstrates how to decide for each external resource in your own code
    /// with an IExternalResourceHandler: PNG images from one trusted host are loaded, everything else keeps the default decision.
    /// </summary>
    public class DecideExternalResourcesWithHandler
    {
        public static void Run()
        {
            Console.WriteLine("=======================================================================");
            Console.WriteLine();
            Console.WriteLine("Example Advanced Usage: DecideExternalResourcesWithHandler");
            Console.WriteLine();

            string filePath = Constants.SAMPLE_HTML_WITH_EXTERNAL_RESOURCES;
            string filePathOut = Path.Combine(Constants.GetOutputDirectoryPath(), Constants.SAMPLE_NAME + Path.GetExtension(filePath));

            LoadOptions loadOptions = new LoadOptions(FileType.HTML)
            {
                ExternalResourceHandler = new TrustedPngHandler()
            };

            using (Merger merger = new Merger(filePath, loadOptions))
            {
                merger.Join(Constants.SAMPLE_HTML);
                merger.Save(filePathOut);
            }

            Console.WriteLine("Documents joined with resources allowed by the handler.");
            Console.WriteLine($"Check output {filePathOut}.");
        }

        private class TrustedPngHandler : IExternalResourceHandler
        {
            public void OnLoading(ExternalResourceLoadingArgs args)
            {
                Uri uri;
                if (Uri.TryCreate(args.Uri, UriKind.Absolute, out uri)
                    && uri.Scheme == Uri.UriSchemeHttps
                    && string.Equals(uri.Host, "raw.githubusercontent.com", StringComparison.OrdinalIgnoreCase)
                    && uri.AbsolutePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                {
                    args.Skipped = false;
                }

                Console.WriteLine("{0}: {1}", args.Skipped ? "skipped" : "loaded", args.Uri);
            }
        }
    }
}
