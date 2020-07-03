---
id: merge-files
url: merger/net/merge-files
title: Merge files
weight: 3
description: "This article explains how to merge files of PDF, Microsoft Word, Excel and PowerPoint and other formats using GroupDocs.Merger API."
keywords: Merge files, Combine files, Merge documents
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to merge multiple documents into single document nice and easy. The result will contain the content of all source documents with all data, styles and formatting. Here are the simple steps to merge several documents of any [supported format]({{< ref "merger/net/getting-started/supported-document-formats.md" >}}):

*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/join/methods/2) method and pass next merged document file path or stream to it. Repeat this step for every merged document.
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method specifying file path to save resultant document.

{{< alert style="info" >}}Please note that all merged documents should be of the same format.{{< /alert >}}

The following code sample demonstrates how to merge documents:

```csharp
using (Merger merger = new Merger(@"c:\sample1.docx"))
{
    merger.Join(@"c:\sample2.docx");
    merger.Join(@"c:\sample3.docx");
    merger.Save(@"c:\merged.docx");
}
```
  
Please learn more about how to merge PDF, Microsoft Word, Microsoft PowerPoint or Open Document documents from the articles listed below:

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
