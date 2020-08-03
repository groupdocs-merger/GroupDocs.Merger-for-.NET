---
id: migration-notes
url: merger/net/migration-notes
title: Migration Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
### Why To Migrate?
 
Here are the key reasons to use the new updated API provided by GroupDocs.Merger for .NET since version 19.9:
*   **[Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger)** class introduced as a **single entry point** to manage the document processing of any supported file format (instead of **DocumentHander** class from previous versions).     
*   Product architecture was redesigned from scratch in order to **decreased memory usage** (from 10% to 400% approx. depending on document type).    
*   Document processing **API simplified and improved** so it’s easy to instantiate proper options class and control over document structure manipulation processes.
    

### How To Migrate?

Here is a brief comparison of how to join documents using old and new API.  

**Old coding style**

```csharp
string sourceFile1 = CommonUtilities.fileOne + fileOne;
string sourceFile2 = CommonUtilities.fileTwo + fileTwo;


// Preparing.
string password = "SomePasswordString";
Stream openFile1 = new FileStream(sourceFile1, FileMode.Open);
Stream openFile2 = new FileStream(sourceFile2, FileMode.Open);

List<JoinItem> documentStreams = new List<JoinItem>();

JoinItem item1 = new JoinItem(openFile1, FileFormat.Docx, password);
documentStreams.Add(item1);
JoinItem item2 = new JoinItem(openFile2, FileFormat.Docx, password);
documentStreams.Add(item2);


// Main method.
DocumentResult result = new DocumentHandler().Join(documentStreams);

Stream documentStream = result.Stream;
var fileStream = File.Create(CommonUtilities.outputPath + "OutPut." + FileFormat.Docx);
documentStream.CopyTo(fileStream);
documentStream.Close();
```

**New coding style**

```csharp
using (Merger merger = new Merger(@"c:\sample1.docx"))
{
    merger.Join(@"c:\sample2.docx");
    merger.Save(@"c:\output\result.docx");
}
```

For more code examples and specific use cases please refer to our [Developer Guide]({{< ref "merger/net/developer-guide/_index.md" >}}) documentation or [GitHub](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET) samples and showcases.
