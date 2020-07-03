---
id: merge-word-documents
url: merger/net/merge-word-documents
title: Merge Word documents
weight: 3
description: "Follow this guide and learn how to merge Word documents, combine several DOCX or DOC files into one using GroupDocs.Merger."
keywords: Merge Word, Merge DOCX, Merge DOC, Join DOCX, Combine DOC
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** provides an easy way to merge Microsoft Word documents of DOC, DOCX, DOCM, DOT, DOTX, DOTM, RTF formats and Open Document formats like ODT, OTT etc. It takes just single line of code to append one document to another preserving all content - page setup, headers and footers, formatting, styles and other content. There is no third-party applications required (like Microsoft Word and Open Office).   
GroupDocs.Merger API provides different overloads of [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join/index) method to combine presentations with the source document loaded into [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object. 

*   [Join(String)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/2) - allows to merge document provided via file path on a local disk; 
*   [Join(Stream)](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join) - provides an ability to combine documents loaded from any source - memory stream, remote URL etc.;
*   [Join(String, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/3) - is used for merging specific pages for document stored at local disk; 
*   [Join(Stream, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/1) - used for merging specific pages from document provided as a stream.

This code sample shows how to merge Microsoft Word documents:

```csharp
using (Merger merger = new Merger(@"c:\document1.docx"))
{
    merger.Join(@"c:\document2.docx");
    merger.Save(@"c:\merged.docx");
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
