# API to Merge & Split Documents

[GroupDocs.Merger for .NET](https://products.groupdocs.com/merger/net) allows developers to merge several documents into one, split single document to multiple documents, reorder or replace document pages, change page orientation, manage document protection, render documents as images and more. 

<p align="center">

  <a title="Download complete GroupDocs.Merger for .NET source code" href="https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/tree/master/Demos) | Source code for live demos hosted at https://products.groupdocs.app/merger/family.
[Docs](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/tree/master/Docs)  | Product documentation containing the Developer's Guide, Release Notes and more.
[Examples](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/tree/master/Examples)  | C# examples and sample files that will help you learn how to use product features. 

## Document Merger & Splitting Features

- [40+ supported document formats](https://docs.groupdocs.com/merger/net/supported-document-formats/).
- [Merge two or more documents into a single file](https://docs.groupdocs.com/merger/net/merge-files/).
- Join specific or group of pages from various files into one document.
- Split a document into several resultant documents.
- Split document by providing specific page numbers.
- Split document to several multiple page files by providing various page intervals.
- Specify exact line numbers to create its separate one-liner file.
- Change page position within a document.
- Remove single or multiple pages from document.
- Remove several pages from a document based on page number.
- Rotate page to an angle of 90, 180 or 270 degrees.
- Swap position of two pages within a document.
- Extract specific page or a range of pages from the document.
- Change page orientation (portrait, landscape) of specific or all pages within a document.
- [Set, update or remove document password](https://docs.groupdocs.com/merger/net/security-operations/).
- Obtain basic meta information about the document.
- [Generate image representation of the document pages](https://docs.groupdocs.com/merger/net/generate-document-pages-preview/).

## Supported Formats for Document Joining & Splitting

**Microsoft Word:** DOC, DOCX, DOCM, DOT, DOTX, DOTM, RTF\
**Microsoft Excel:** XLS, XLSX, XLSB, XLSM, XLT, XLTX, XLTM, XLAM\
**Microsoft PowerPoint:** PPT, PPTX, PPS, PPSX\
**Microsoft Visio:** VSDX, VSDM, VSSX, VSSM, VSTX, VSTM, VDX, VSX, VTX\
**Microsoft OneNote:** ONE\
**OpenOffice:** ODT, OTT, ODP, OTP, ODS\
**Web:** HTML, MHT\
**Portable:** PDF, XPS\
**Text:** TXT\
**Other:** TEX, EPUB, CSV, TSV

## Develop & Deploy GroupDocs.Merger Anywhere

**Microsoft Windows:** Microsoft Windows Desktop & Server (x86, x64), Windows Azure\
**macOS:** Mac OS X\
**Linux:** Ubuntu, OpenSUSE, CentOS, and others\
**Development Environments:** Microsoft Visual Studio, Xamarin.Android, Xamarin.IOS, Xamarin.Mac, MonoDevelop.\
**Supported Frameworks:** NET Standard 2.0, .NET Framework 2.0 or higher, .NET Core 2.0 or higher, Mono Framework 1.2 or higher

## Get Started with GroupDocs.Merger for .NET

Are you ready to give GroupDocs.Merger for .NET a try? Simply execute `Install-Package GroupDocs.Merger` from Package Manager Console in Visual Studio to fetch & reference GroupDocs.Merger assembly in your project. If you already have GroupDocs.Merger for .Net and want to upgrade it, please execute `Update-Package GroupDocs.Merger` to get the latest version.

## Join Specific Pages from Various Documents

```csharp
string filePath = @"c:\sample.docx";
string filePath2 = @"c:\sample2.docx";
string filePathOut = @"c:\output\result.docx";

JoinOptions joinOptions = new JoinOptions(1, 4, RangeMode.OddPages);

using (Merger merger = new Merger(filePath, loadOptions))
{
    merger.Join(filePath2, joinOptions);
    merger.Save(filePathOut);
}
```

## Swap Page Position within a Document via C# Code

```csharp
string filePath = @"c:\sample.pptx";
string filePathOut = @"c:\output\result.pptx";

int pageNumber1 = 3;
int pageNumber2 = 6;
SwapOptions swapOptions = new SwapOptions(pageNumber2, pageNumber1);

using (Merger merger = new Merger(filePath))
{
    merger.SwapPages(swapOptions);
    merger.Save(filePathOut);
}
```

[Home](https://www.groupdocs.com/) | [Product Page](https://products.groupdocs.com/merger/net) | [Documentation](https://docs.groupdocs.com/merger/net/) | [Demo](https://products.groupdocs.app/assembly/family) | [API Reference](https://apireference.groupdocs.com/merger/net) | [Examples](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET) | [Blog](https://blog.groupdocs.com/category/merger/) | [Free Support](https://forum.groupdocs.com/c/merger) | [Temporary License](https://purchase.groupdocs.com/temporary-license)
