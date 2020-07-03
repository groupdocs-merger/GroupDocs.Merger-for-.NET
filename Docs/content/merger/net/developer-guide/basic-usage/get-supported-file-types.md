---
id: get-supported-file-types
url: merger/net/get-supported-file-types
title: Get supported file types
weight: 1
description: "This article explains how to obtain supported file formats list when merge PDF, Word, Excel, PowerPoint documents with GroupDocs.Merger within your .NET applications."
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to get the list of all [supported file types]({{< ref "merger/net/getting-started/supported-document-formats.md" >}}) by following the below steps:

*   Call [GetSupportedFileTypes](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain/filetype/methods/getsupportedfiletypes) of [FileType](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain/filetype) class;
*   Enumerate through the collection of [FileType](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain/filetype) objects.

The following code sample demonstrates how to get supported file formats list.

```csharp
IEnumerable<FileType> supportedFileTypes = FileType
	.GetSupportedFileTypes()
	.OrderBy(f => f.Extension);

foreach (FileType fileType in supportedFileTypes)
	Console.WriteLine(fileType);
```

## More resources
### Advanced Usage Topics 
To learn more about document merging features, please refer the [advanced usage section]({{< ref "merger/net/developer-guide/advanced-usage/_index.md" >}}).

### GitHub Examples 
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Merger for .NET examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET)    
*   [GroupDocs.Merger for Java examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-Java)    

### Free Online App

Along with full featured .NET library we provide simple, but powerful free Apps.  
You are welcome to merge your documents with our free online **[GroupDocs Merger App](https://products.groupdocs.app/merger)**.
