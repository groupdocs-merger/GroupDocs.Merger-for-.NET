---
id: merge-pages-from-various-documents
url: merger/net/merge-pages-from-various-documents
title: Merge pages from various documents
weight: 4
description: "This article explains how to merge some pages from different documents into single PDF, DOCX, Excel or PowerPoint document using GroupDocs.Merger for .NET."
keywords: Merge PDF pages into one PDF document, Combine document pages into single document, Merge pages into document using GroupDocs.Merger for .NET
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to merge the source document with specific document pages from joined document into one resultant document by specifying desired page numbers or page ranges. Joined documents should be of the same format.

 Here are the steps to join several document parts:

*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Instantiate [JoinOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/joinoptions) object and specify desired page numbers or page range to join;
*   Call [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/3) method and pass joined document file path or stream to it specifying [JoinOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/joinoptions) object as parameter. Repeat this step for every joined document part.
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method specifying file path to save resultant document.

The following code sample demonstrates how to join document parts:

```csharp
string filePath = @"c:\sample.docx";
string filePath2 = @"c:\sample2.docx";
string filePathOut = @"c:\output\result.docx";

JoinOptions joinOptions = new JoinOptions(1, 4, RangeMode.OddPages);

using (Merger merger = new Merger(filePath, loadOptions))
{
    merger.Join(filePath2, joinOptions);
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
