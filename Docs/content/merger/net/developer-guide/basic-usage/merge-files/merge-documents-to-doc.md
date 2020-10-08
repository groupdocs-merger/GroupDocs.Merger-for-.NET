---
id: merge-documents-to-doc
url: merger/net/merge-documents-to-doc
title: Merge documents to DOC
weight: 6
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
## Introduction

Consider the functionality for merging files of various formats such as [DOC](https://docs.fileformat.com/word-processing/doc/), [PDF](https://docs.fileformat.com/view/pdf/), [XPS](https://docs.fileformat.com/page-description-language/xps/), [EPUB](https://docs.fileformat.com/ebook/epub/) and [TEX](https://docs.fileformat.com/page-description-language/tex/) into a DOC document. Let's see, why do we need to combine these files into a DOC document? This article discusses the DOC format, but those ones will be more in the near future. But turn back to the DOC format. It is a standard format that allows you to display information the same on any device with any platform. It is comfortable for transferring info via the Internet or to a printer. That is why this format is chosen for the current task of combining files of various formats.

## Merge documents to DOC / DOCX

Multiple files (even different types of PDF files such as [PDF](https://docs.fileformat.com/view/pdf/), [XPS](https://docs.fileformat.com/page-description-language/xps/), [EPUB](https://docs.fileformat.com/ebook/epub/) and [TEX](https://docs.fileformat.com/page-description-language/tex/)) can be combined into a single DOC / DOCX file by using **[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** API. You can also use this [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join/index) method to combine multiple DOC / DOCX files. This cross-format merge to DOC / DOCX could be useful for the cases when there is no ability to merge only DOC files. For now, GroupDocs.Merger API allows to [Join](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/join/index) other file types without password with the DOC / DOCX document loaded into [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object.

The following example demonstrates how to merge DOC file with [PDF](https://docs.fileformat.com/view/pdf/), [XPS](https://docs.fileformat.com/page-description-language/xps/), [EPUB](https://docs.fileformat.com/ebook/epub/) and [TEX](https://docs.fileformat.com/page-description-language/tex/) file types:

```csharp
using (Merger merger = new Merger(@"c:\document1.doc"))
{
    merger.Join(@"c:\document2.pdf");
    merger.Join(@"c:\document3.xps");
    merger.Join(@"c:\document4.epub");
    merger.Join(@"c:\document5.tex");
 
	merger.Save(@"c:\merged.doc");
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
