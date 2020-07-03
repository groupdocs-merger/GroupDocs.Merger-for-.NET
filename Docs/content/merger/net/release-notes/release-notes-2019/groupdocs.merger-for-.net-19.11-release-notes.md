---
id: groupdocs-merger-for-net-19-11-release-notes
url: merger/net/groupdocs-merger-for-net-19-11-release-notes
title: GroupDocs.Merger for .NET 19.11 Release Notes
weight: 2
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Merger for .NET 19.11{{< /alert >}}

There are a few new other features in this regular monthly release. The most notable are:

*   Fixed loading of the password-protected Odp and Otp formats;
*   Fixed Total license loading for .Net standard product.

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| MERGERNET-557 | Protected Odp and Otp is not supported | Bug |
| MERGERNET-733 | Compatibility issues under .NET Standard 2.0 | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Merger for .NET 19.11. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Merger which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

1.  Refactoring options and enumerations related to Split operation
    1.  Renamed options and enumerations related to Split operation  
        1.  Renamed class **PageSplitOptions** to **SplitOptions**;
        2.  Removed interface **IPageSplitOptions** and used **ISplitOptions** instead;
        3.  Renamed enumeration **PageSplitMode** to **SplitMode**.
    2.  Moved **PageSplitOptions** (SplitOptions after renaming) constructor optional parameters to the end of parameters list:
        1.  Changed parameters order *PageSplitOptions(string filePathFormat, **PageSplitMode splitMode**, int\[\] pageNumbers)*  
            to *SplitOptions(string filePathFormat, int\[\] pageNumbers, **SplitMode splitMode**);*
        2.  Changed parameters order **PageSplitOptions(CreateSplitStream createSplitStream, **PageSplitMode splitMode**, int\[\] pageNumbers)*  
            to *SplitOptions(CreateSplitStream createSplitStream, int\[\] pageNumbers, **SplitMode splitMode**);**
        3.  Changed parameters order ***PageSplitOptions(CreateSplitStream createSplitStream, ReleaseSplitStream releaseSplitStream, **PageSplitMode splitMode**, int\[\] pageNumbers)*  
            to *SplitOptions(CreateSplitStream createSplitStream, ReleaseSplitStream releaseSplitStream, int\[\] pageNumbers, **SplitMode splitMode**).***
