---
id: remove-document-password
url: merger/net/remove-document-password
title: Remove document password
weight: 3
description: "This article explains how to remove password for PDF, Word, Excel, PowerPoint documents by using GroupDocs.Merger for .NET."
keywords: Remove document password protection, Remove PDF password, Remove Word document password, Remove Excel spreadsheet password, Remove PowerPoint presentation password
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to remove password from password-protected document. Here are the steps to remove document password:

*   Initialize [LoadOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/loadoptions) class specifying current password;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream and pass [LoadOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/loadoptions) object to it;
*   Call [RemovePassword](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/removepassword) method;
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method specifying file path to save resultant document.

The following code sample demonstrates how to remove document password:

```csharp
string filePath = @"c:\sample.docx";
string filePathOut = @"c:\output\result.docx";

LoadOptions loadOptions = new LoadOptions("SAMPLE_PASSWORD");

using (Merger merger = new Merger(filePath, loadOptions))
{
    merger.RemovePassword();
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
