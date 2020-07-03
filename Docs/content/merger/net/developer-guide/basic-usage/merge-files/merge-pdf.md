---
id: merge-pdf
url: merger/net/merge-pdf
title: Merge PDF
weight: 1
description: "Follow this guide and learn how to merge PDF files, combine several PDFs into one using GroupDocs.Merger API and couple lines of code."
keywords: Merge PDF, Combine PDF, Join PDF, PDF document merger
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows you to merge PDF files when it's needed to organize multiple PDFs into single document or send fewer attachments etc. And you can do this without any third-party software or manual work involved.  
With GroupDocs.Merger it is possible to combine PDF documents of any size and structure - all text, images, tables, graphs, forms and other content will be preserved.   
Supported PDF format versions are 1.2, 1.3, 1.4, 1.5, 1.6 and 1.7.

GroupDocs.Merger API provides several overloads of [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join/index) method to combine additional files with the source document loaded into [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object. 

*   [Join(String)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/2) - allows to merge document provided via file path on a local disk; 
*   [Join(Stream)](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join) - provides an ability to combine documents loaded from any source - memory stream, remote URL etc.;
*   [Join(String, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/3) - is used for merging specific pages for document stored at local disk; 
*   [Join(Stream, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/1) - used for merging specific pages from document provided as a stream.

The following example demonstrates how to merge PDF files with several lines of code:

```csharp
using (Merger merger = new Merger(@"c:\document1.pdf"))
{
    merger.Join(@"c:\document2.pdf");
    merger.Save(@"c:\merged.pdf");
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