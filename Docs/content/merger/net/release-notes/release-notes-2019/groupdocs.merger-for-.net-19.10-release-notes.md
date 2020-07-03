---
id: groupdocs-merger-for-net-19-10-release-notes
url: merger/net/groupdocs-merger-for-net-19-10-release-notes
title: GroupDocs.Merger for .NET 19.10 Release Notes
weight: 3
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Merger for .NET 19.10{{< /alert >}}

## Major Features

**.NET Standard 2.0**

Starting from 19.10 release GroupDocs.Merger for .NET includes .NET Standard 2.0 version. It has full functionality of regular .NET version of GroupDocs.Merger with few limitations:

*   Password-protected documents of .One format is not supported.

There are a few new other features in this regular monthly release. The most notable are:

*   Fixed the Xlsb format loading with unknown FileType;
*   Fixed merging of the ODP files with empty table;
*   Added Encoding usage of LoadOptions to the text splitting.

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| MERGERNET-627 | Add .NET Standard 2.0 support | New Feature |
| MERGERNET-668 | Add LoadOptions Encoding usage for the text splitting | Improvement |
| MERGERNET-655 | Format Xlsb is not load with unknown FileType | Bug |
| MERGERNET-686 | Cannot merge ODP files with table | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Merger for .NET 19.10. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Merger which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  **LoadOptions Encoding usage for the text splitting**  
    The following example demonstrates how to use Encoding for the text splitting:
    
    **Split method**
    
    ```csharp
    // Variables.
    string filePath = @"c:\sample.txt";
    string filePathOut = @"c:\output\line_{0}.{1}";
      
    // Options.
    LoadOptions loadOptions = new LoadOptions(FileType.Txt, Encoding.Unicode);
    TextSplitOptions splitOptions = new TextSplitOptions(filePathOut, new int[] { 3, 6 });
      
    using (Merger merger = new Merger(filePath, loadOptions))
    {
        merger.Split(splitOptions);
    }
    ```
