---
id: load-document-from-url
url: merger/net/load-document-from-url
title: Load document from URL
weight: 3
description: "This article explains how to load PDF, Word, Excel, PowerPoint documents from URL when using GroupDocs.Merger for .NET."
keywords: Load document from URL, Load document by URL GroupDocs.Merger
productName: GroupDocs.Merger for .NET
hideChildren: False
---
Following example demonstrates how to load document from URL.

```csharp
 		public static void Run()
        {
            string url = "https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/blob/master/Examples/Resources/SampleFiles/Pdf/example.pdf?raw=true";
            
            using (Stream stream = GetRemoteFile(url))
            {
                using (Merger merger = new Merger(stream))
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
               | SecurityProtocolType.Ssl3;
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
```

## More resources
### GitHub Examples 
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Merger for .NET examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET)    
*   [GroupDocs.Merger for Java examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-Java)    

### Free Online App

Along with full featured .NET library we provide simple, but powerful free Apps.  
You are welcome to merge your documents with our free online **[GroupDocs Merger App](https://products.groupdocs.app/merger)**.
