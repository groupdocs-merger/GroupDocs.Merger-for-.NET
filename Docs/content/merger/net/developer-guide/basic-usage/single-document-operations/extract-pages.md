---
id: extract-pages
url: merger/net/extract-pages
title: Extract pages
weight: 6
description: "Following this guide you will learn how to extract pages from PDF, Word, Excel, PowerPoint and many other file types using GroupDocs.Merger for .NET."
keywords: Extract page from PDF, Extract page from Word, Extract worksheet from Excel, Extract slide from PowerPoint, Extract document pages
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**GroupDocs.Merger** allows to extract pages from source document. The result is a new document that contains only specified pages from the source document.

Here are the steps to extract document pages:

*   Initialize [ExtractOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/extractoptions) class with page numbers that should appear in the resultant document;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [ExtractPages](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/extractpages) method and pass [ExtractOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/extractoptions) object to it;
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method specifying file path to save resultant document.

The following code sample demonstrates how to extract document pages **by specifying exact page numbers**:

```csharp
string filePath = @"c:\sample.pdf";
string filePathOut = @"c:\output\result.pdf";

ExtractOptions extractOptions = new ExtractOptions(new int[] { 1, 4 }); // Resultant document will contain pages 1 and 4

using (Merger merger = new Merger(filePath))
{
    merger.ExtractPages(extractOptions);
    merger.Save(filePathOut);
}
```

The following code sample demonstrates how to extract document pages **by specifying page numbers range**:

```csharp
string filePath = @"c:\sample.pdf";
string filePathOut = @"c:\output\result.pdf";

ExtractOptions extractOptions = new ExtractOptions(1, 3, RangeMode.EvenPages); // Resultant document will contain page 2
using (Merger merger = new Merger(filePath))
{
	merger.ExtractPages(extractOptions);
    merger.Save(filePathOut);
}
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