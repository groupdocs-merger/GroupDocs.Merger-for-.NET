---
id: split-document
url: merger/net/split-document
title: Split document
weight: 3
description: "This guide describes how to split document of PDF, Word, Excel, PowerPoint and many other formats into several resultant documents using GroupDocs.Merger API."
keywords: Split document, Split PDF, Split Word, Split DOC, Split Presentation, Split Excel
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**GroupDocs.Merger** allows to split source document into several resultant documents. Document splitting can be performed in different ways by specifying page numbers array or start/end page numbers and setting different [SplitOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/splitoptions) modes.  
Here are the possible use cases:

1.  **Page numbers array** specified and splitting mode is set to [SplitMode](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/splitmode).Pages - specified page numbers indicate exact page numbers, which will be saved to the separate one-page documents.  
    *Ex:* Array{ 3, 6, 8 } will produce 3 documents with 3rd, 6th and 8th pages.
    
2.  **Page numbers array** specified and splitting mode is set to [SplitMode](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/splitmode).Interval  - specified page numbers indicate the boundaries of the page intervals, which will be saved to the separate multi-page documents.  
    *Ex:* Array{ 3, 6, 8 } will produce 4 page intervals 1-2, 3-5, 6-7, 8-10.    

There is also an ability to set parameter [RangeMode](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/rangemode) and obtain only even or odd pages from desired pages range.  
  
The steps to split document to multiple on-page documents are the following:

*   Initialize [SplitOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/splitoptions) class with output files path format;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [Split](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/split) method and pass [SplitOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/splitoptions) object to itfor saving resultant documents.

## Split the document to several one-page documents (by exact page numbers)

The following code sample demonstrates how to split document to three one-page documents with 3rd, 6th and 8th pages:

```csharp
string filePath = @"c:\sample.docx";
string filePathOut = @"c:\output\document_{0}.{1}";

SplitOptions splitOptions = new SplitOptions(filePathOut, new int[] { 3, 6, 8 });
           
using (Merger merger = new Merger(filePath))
{
     merger.Split(splitOptions);
}  
```

This code snippet will  produce:

| Document name | Page numbers |
| --- | --- |
| document_3 | 3 |
| document_6 | 6 |
| document_8 | 8 |

## Split the document to several one-page documents (by start/end page numbers)

The following code sample demonstrates how to split document to several one-page documents starting from 3rd and ending at 7th page number:

```csharp
string filePath = @"c:\sample.docx";
string filePathOut = @"c:\output\document_{0}.{1}";

SplitOptions splitOptions = new SplitOptions(filePathOut, 3, 7);
           
using (Merger merger = new Merger(filePath))
{
     merger.Split(splitOptions);
}  
```

This code snippet will  produce:

| Document name | Page numbers |
| --- | --- |
| document_3 | 3 |
| document_4 | 4 |
| document_5 | 5 |
| document_6 | 6 |
| document_7 | 7 |

## Split the document to several one-page documents (by start/end page numbers and even/odd filter)

The following code sample demonstrates how to split document to several one-page documents for odd pages starting from 3rd and ending at 7th page number:

```csharp
string filePath = @"c:\sample.docx";
string filePathOut = @"c:\output\document_{0}.{1}";

SplitOptions splitOptions = new SplitOptions(filePathOut, 3, 7, RangeMode.OddPages);
           
using (Merger merger = new Merger(filePath))
{
     merger.Split(splitOptions);
}  
 
```

This code snippet will  produce:

| Document name | Page numbers |
| --- | --- |
| document_3 | 3 |
| document_5 | 5 |
| document_7 | 7 |

## Split the document to several multi-page documents

The following code sample demonstrates how to split document to several multi-page documents:

```csharp
string filePath = @"c:\sample.docx";
string filePathOut = @"c:\output\document_{0}.{1}";

SplitOptions splitOptions = new SplitOptions(filePathOut, new int[] { 3, 6, 8 }, SplitMode.Interval);
           
using (Merger merger = new Merger(filePath))
{
     merger.Split(splitOptions);
}  
```

This code snippet will  produce:

| Document name | Page numbers |
| --- | --- |
| document_0 | 1, 2 |
| document_1 | 3, 4, 5 |
| document_2 | 6, 7 |
| document_3 | 8, 9, 10 |

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