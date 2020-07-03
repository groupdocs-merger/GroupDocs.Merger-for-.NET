---
id: load-password-protected-document
url: merger/net/load-password-protected-document
title: Load password-protected document
weight: 2
description: "This article explains how to load password-protected PDF, Word, Excel, PowerPoint documents when using GroupDocs.Merger for .NET."
keywords: Load password-protected document, Load protected document with GroupDocs.Merger
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to manipulate with documents that are protected with a password.

The following are the steps to load password-protected documents.

*   Instantiate [LoadOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/loadoptions) object and specify source document password;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream and [LoadOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/loadoptions) object created at previous step.

The following code sample shows how to load password-protected documents.

```csharp
string filePath = @"c:\sample.docx";
LoadOptions loadOptions = new LoadOptions("SAMPLE_PASSWORD");
 
using (Merger merger = new Merger(filePath, loadOptions))
{
	Console.WriteLine($"Document loaded successfully.");                
}    
```

## More resources
### GitHub Examples 
You may easily run the code above and see the feature in action in our GitHub examples:
*   [GroupDocs.Merger for .NET examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET)    
*   [GroupDocs.Merger for Java examples, plugins and showcase](https://github.com/groupdocs-merger/GroupDocs.Merger-for-Java)    

### Free Online App

Along with full featured .NET library we provide simple, but powerful free Apps.  
You are welcome to merge your documents with our free online **[GroupDocs Merger App](https://products.groupdocs.app/merger)**.
