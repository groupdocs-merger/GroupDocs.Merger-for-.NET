---
id: groupdocs-merger-for-net-19-7-release-notes
url: merger/net/groupdocs-merger-for-net-19-7-release-notes
title: GroupDocs.Merger for .NET 19.7 Release Notes
weight: 5
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Merger for .NET 19.7{{< /alert >}}

## Major Features

There are a few new features in this regular monthly release. The most notable are:

*   Implemented a new method GetDocumentInfo
*   Implemented a new format .html
*   Implemented .tiff image joining

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| MERGERNET-431 | Implement a new method GetDocumentInfo | New Feature |
| MERGERNET-513 | Implement a new format .html | New Feature |
| MERGERNET-544 | Implement .tiff image joining | New Feature |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Merger for .NET 19.7. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Merger which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  The **DocumentHandler** class was extended with a new **GetDocumentInfo** method
    
    **GetDocumentInfo method**
    
    ```csharp
    /// <summary>
    /// Get information about document.
    /// </summary>
    public DocumentInfo GetDocumentInfo(Stream stream)
     
    /// <summary>
    /// Get information about document.
    /// </summary>
    public DocumentInfo GetDocumentInfo(Stream stream, string password)
     
    /// <summary>
    /// Get information about document.
    /// </summary>
    public DocumentInfo GetDocumentInfo(Stream stream, Options options)
    ```
    
    Following example demonstrates how to use a new **GetDocumentInfo** method:
    ```csharp
    // Variables.
    string sourceFile = "C:\testfiles\filename";
     
    // Preparing.
    Stream documentExample = new FileStream(sourceFile, FileMode.Open);
     
    // Main method.
    DocumentInfo resultInfo = new DocumentHandler().GetDocumentInfo(documentExample);
    ```
