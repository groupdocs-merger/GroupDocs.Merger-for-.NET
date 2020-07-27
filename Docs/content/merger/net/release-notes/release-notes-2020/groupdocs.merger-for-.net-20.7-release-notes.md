---
id: groupdocs-merger-for-net-20-7-release-notes
url: merger/net/groupdocs-merger-for-net-20-7-release-notes
title: GroupDocs.Merger for .NET 20.7 Release Notes
weight: 60
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="info" >}}This page contains release notes for GroupDocs.Merger for .NET 20.7{{< /alert >}}

## Major Features

There are a few fixed bugs under .Net Core platform in this regular monthly release. The most notable are:

*   System.NotSupportedException : Could not open display (X-Server required. Check your DISPLAY environment variable);
*   System.Exception : 'file:///d:/EPUB/out.xhtml' could not be found;
*   System.DllNotFoundException : Unable to load shared library 'gdi32.dll' or one of its dependencies. In order to help diagnose loading problems, consider setting the LD_DEBUG environment variable: libgdi32.dll: cannot open shared object file: No such file;
*   KeyNotFoundException: The given key 'Wingdings' was not present in the dictionary;
*   System.PlatformNotSupportedException : COM Interop is not supported on this platform;
*   MHT and MHTML file types have only one page under Linux and could not be used for the page modification.

## Full List of Issues Covering all Changes in this Release

| Key | Summary | Category |
| --- | --- | --- |
| MERGERNET-876 | System.NotSupportedException : Could not open display (X-Server required. Check your DISPLAY environment variable) | Bug |
| MERGERNET-877 | System.Exception : 'file:///d:/EPUB/out.xhtml' could not be found | Bug |
| MERGERNET-878 | System.DllNotFoundException : Unable to load shared library 'gdi32.dll' or one of its dependencies. In order to help diagnose loading problems, consider setting the LD_DEBUG environment variable: libgdi32.dll: cannot open shared object file: No such file | Bug |
| MERGERNET-880 | KeyNotFoundException: The given key 'Wingdings' was not present in the dictionary | Bug |
| MERGERNET-886 | System.PlatformNotSupportedException : COM Interop is not supported on this platform | Bug |
| MERGERNET-888 | MHT and MHTML file types have only one page under Linux and could not be used for the page modification | Bug |

## Public API and Backward Incompatible Changes

{{< alert style="info" >}}This section lists public API changes that were introduced in GroupDocs.Merger for .NET 20.7. It includes not only new and obsoleted public methods, but also a description of any changes in the behavior behind the scenes in GroupDocs.Merger which may affect existing code. Any behavior introduced that could be seen as a regression and modifies existing behavior is especially important and is documented here.{{< /alert >}}

### None.
