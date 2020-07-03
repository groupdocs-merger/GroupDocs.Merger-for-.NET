---
id: rotate-pages
url: merger/net/rotate-pages
title: Rotate pages
weight: 8
description: "Following this guide you will learn how to change PDF document page rotation angle using GroupDocs.Merger for .NET API."
keywords: Rotate PDF pages, Rotate document pages, Change PDF page rotation angle 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to change page rotation angle by setting it to 90, 180 or 270 degrees for specific or all document pages.  
Here are the steps to change page rotation:

*   Initialize [RotateOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/rotateoptions) class with desired rotation angle and page numbers;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [RotatePages](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/rotatepages) method and pass [RotateOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/rotateoptions) object to it;
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method specifying file path to save resultant document.

The following code sample demonstrates how to change page rotation:

```csharp
string filePath = @"c:\sample.pdf";
string filePathOut = @"c:\output\result.pdf";

RotateOptions rotateOptions = new RotateOptions(RotateMode.Rotate180, new int[] { 2, 3, 6 });

using (Merger merger = new Merger(filePath))
{
    merger.RotatePages(rotateOptions);
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
