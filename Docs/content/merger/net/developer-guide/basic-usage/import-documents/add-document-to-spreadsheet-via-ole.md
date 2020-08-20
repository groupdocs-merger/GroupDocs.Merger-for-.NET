---
id: add-document-to-spreadsheet-via-ole
url: merger/net/add-document-to-spreadsheet-via-ole
title: Add document to Spreadsheet via OLE
weight: 4
description: "This article explains how to add document to Spreadsheet via OLE with GroupDocs.Merger within your .NET applications."
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
## What is OLE object for Spreadsheet?

The OLE technology provided by Microsoft allows to insert some other document content into the cell that is previosly selected by RowIndex and ColumnIndex of the currently editing Excel spreadsheet. For example, the PDF document can be inserted in the Excel spreadsheet document as image link inside of predefined cell as was presented in the example below.

## Add document to Spreadsheet via OLE

**[GroupDocs.Merger](https://products.groupdocs.com/merger/net)** provides an ability to add other single document as embedded document to Presentation.   
Here are the steps for it:

*   Initialise [OleSpreadsheetOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/olespreadsheetoptions) class with embedded file path and page number;
*   Instantiate [Merger](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger) object with source document path or stream;
*   Call [ImportDocument](https://apireference.groupdocs.com/net/merger/groupdocs.merger/merger/methods/importdocument) method and pass [OleSpreadsheetOptions](https://apireference.groupdocs.com/net/merger/groupdocs.merger.domain.options/olespreadsheetoptions) object to it;
*   Call [Save](https://apireference.groupdocs.com/net/merger/groupdocs.merger.merger/save/methods/1) method and pass desired file path to save resultant document.

The following code sample demonstrates how to add other single document as embedded document to Excel spreadsheet:

```csharp
string filePath = @"c:\sample.xlsx";
string filePathEmbedded = @"c:\embedded.pdf";
string filePathOut = @"c:\output\result.xlsx";

int pageNumber = 2;
OleSpreadsheetOptions oleSpreadsheetOptions = new OleSpreadsheetOptions(filePathEmbedded, pageNumber);
oleSpreadsheetOptions.RowIndex = 2;
oleSpreadsheetOptions.ColumnIndex = 2;

using (Merger merger = new Merger(filePath))
{
    merger.ImportDocument(oleSpreadsheetOptions);
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
