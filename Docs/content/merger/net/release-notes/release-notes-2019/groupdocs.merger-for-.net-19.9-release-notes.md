---
id: groupdocs-merger-for-net-19-9-release-notes
url: merger/net/groupdocs-merger-for-net-19-9-release-notes
title: GroupDocs.Merger for .NET 19.9 Release Notes
weight: 4
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Merger for .NET 19.9{{< /alert >}}

## Major Features

{{< alert style="danger" >}}In this version we're introducing new public API which was designed to be simple and easy to use. For more details about new API please check Developer Guide section. The legacy API have been moved into Legacy namespace so after update to this version it is required to make project-wide replacement of namespace usages from GroupDocs.Merger. to GroupDocs.Merger.Legacy. to resolve build issues.{{< /alert >}}

  
Other notable features:

*   Removed support of image joining;
*   Added support of .mht format.

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| MERGERNET-415 | Implement a new format .mht | Feature |
| MERGERNET-602 | Implement a new API of GroupDocs.Merger for .NET product | Feature |

# Public API and Backward Incompatible Changes

#### All public types from GroupDocs.Merger namespace 

1.  Have been moved into **GroupDocs.Merger.Legacy** namespace
2.  Marked as **Obsolete** with message: *This interface/class/enumeration is obsolete and will be available till January 2020 (v20.1).*

#### Full list of namespaces which have been moved and marked as obsolete:
1.  GroupDocs.Merger.Handler => GroupDocs.Merger.Legacy.Handler    
2.  GroupDocs.Merger.Domain => GroupDocs.Merger.Legacy.Domain    
3.  GroupDocs.Merger.Domain.Format => GroupDocs.Merger.Legacy.Domain.Format    
4.  GroupDocs.Merger.Domain.Image => GroupDocs.Merger.Legacy.Domain.Image    
5.  GroupDocs.Merger.Domain.Options => GroupDocs.Merger.Legacy.Domain.Options    
6.  GroupDocs.Merger.Domain.Result => GroupDocs.Merger.Legacy.Domain.Result    
7.  GroupDocs.Merger.Domain.Security => GroupDocs.Merger.Legacy.Domain.Security