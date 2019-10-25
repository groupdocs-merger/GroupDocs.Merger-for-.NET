using System;
using System.IO;
using System.Net;
using GroupDocs.Merger.Domain;
using GroupDocs.Merger.Domain.Options;

namespace GroupDocs.Merger.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to load document from url
    /// </summary>
    public class LoadDocumentFromUrl
    {
        public static void Run()
        {
            string url = "https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/tree/master/Examples/Resources/SampleFiles/Pdf?raw=true";
            
            using (Stream stream = GetRemoteFile(url))
            {
                LoadOptions loadOptions = new LoadOptions(FileType.PDF);
                using (Merger merger = new Merger(stream, loadOptions))
                {
                    Console.WriteLine($"Document loaded from URL successfully.");
                }
            }
        }

        private static Stream GetRemoteFile(string url)
        {
            //ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
               | SecurityProtocolType.Tls11
               | SecurityProtocolType.Tls12
               /*| SecurityProtocolType.Ssl3*/;

            WebRequest request = WebRequest.Create(url);

            using (WebResponse response = request.GetResponse())
                return GetFileStream(response);
        }

        private static Stream GetFileStream(WebResponse response)
        {
            MemoryStream fileStream = new MemoryStream();

            using (Stream responseStream = response.GetResponseStream())
                responseStream.CopyTo(fileStream);

            fileStream.Position = 0;
            return fileStream;
        }
    }
}              
     