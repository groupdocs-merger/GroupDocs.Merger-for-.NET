---
id: check-document-password-protection
url: merger/net/check-document-password-protection
title: Check document password-protection
weight: 2
description: "This article explains how to check whether PDF, Word, Excel, PowerPoint document is password protected or not, and how to do this using GroupDocs.Merger for .NET."
keywords: Check document password protection, Check PDF protected, Check Word document protected, Check Excel document protected
productName: GroupDocs.Merger for .NET
hideChildren: False
---
**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** allows to check document for password-protection. The result will be **true** if document has password for opening set, in other case **false** will be returned.

Here are the steps to check document password-protection:

*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [IsPasswordSet](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/ispasswordset) method.

The following code sample demonstrates how to check document password-protection.

```csharp
bool isPasswordSet = false;
string filePath = @"C:\sample.xlsx";

using (Merger merger = new Merger(filePath))
{
	isPasswordSet = merger.IsPasswordSet();
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
