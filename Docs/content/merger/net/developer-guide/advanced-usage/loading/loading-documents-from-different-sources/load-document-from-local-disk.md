---
id: load-document-from-local-disk
url: merger/net/load-document-from-local-disk
title: Load document from local disk
weight: 1
description: "This article explains how to load PDF, Word, Excel, PowerPoint documents from local disk when using GroupDocs.Merger for .NET."
keywords: Load document from local disk, Load document from file path, Load document with GroupDocs.Merger
productName: GroupDocs.Merger for .NET
hideChildren: False
---
When the source document is located on the local disk **[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows you to load it via [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) class constructor specifying absolute or relative path to it.  
The following code snippet shows how to load documents from local disk.

```csharp
string filePath = @"c:\sample.docx";
using (Merger merger = new Merger(filePath))
{
	Console.WriteLine($"Document loaded from local disk successfully.");
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
