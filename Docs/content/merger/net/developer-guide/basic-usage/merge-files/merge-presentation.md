---
id: merge-presentation
url: merger/net/merge-presentation
title: Merge Presentation
weight: 2
description: "This article explains how to merge PowerPoint presentations, combine several PPTX or PPT files into one using GroupDocs.Merger API and couple lines of code."
keywords: Merge PowerPoint, Merge Presentations, Merge PPT, Merge PPTX, Merge PPSX, Merge PPS, Join PowerPoint, Combine PowerPoint
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** exposes powerful and easy to use API to merge PowerPoint and Open Document presentations of PPT, PPTX, PPS, PPSX and ODP, OTP formats. Presentations can be combined as a whole or on a page by page basis depending on your requirements. The big advantage of GroupDocs.Merger is that presentations can be merged programmatically without any third-party software installed (like Microsoft PowerPoint or Open Office) or manual work.  
GroupDocs.Merger combines presentations with all their content with no quality and data loss - text formatting, comments, animations, smart arts, shapes, etc.  
  
GroupDocs.Merger API provides different overloads of [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join/index) method to combine presentations with the source document loaded into [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object. 

*   [Join(String)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/2) - allows to merge document provided via file path on a local disk; 
*   [Join(Stream)](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join) - provides an ability to combine documents loaded from any source - memory stream, remote URL etc.;
*   [Join(String, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/3) - is used for merging specific pages for document stored at local disk; 
*   [Join(Stream, IJoinOptions)](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/1) - used for merging specific pages from document provided as a stream.

The following example demonstrates how to merge presentations with several lines of code:

```csharp
using (Merger merger = new Merger(@"c:\presentation1.ppt"))
{
    merger.Join(@"c:\presentation2.ppt");
    merger.Save(@"c:\merged.ppt");
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
