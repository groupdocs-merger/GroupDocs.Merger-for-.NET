---
id: features-overview
url: merger/net/features-overview
title: Features Overview
weight: 1
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
GroupDocs.Merger allows you to join multiple documents and manipulate single document structure across wide range of [supported document types]({{< ref "merger/net/getting-started/supported-document-formats.md" >}}). Below, the short list of possible actions:

## Multiple document operations

#### Join Documents

This feature lets you merge two or more documents into one document, join specific pages or page ranges from several source documents into single resultant document.

## Single document operations

#### Split Document

**Split** operation allows to divide a source document to several resultant documents.

#### Move Page

**MovePage** allows to move page to another position within a document. 

#### Remove Pages

**RemovePages** feature provides an ability to remove single page or a collection of specific page numbers from the source document. 

#### Rotate Pages

**RotatePages** operation lets you rotate pages within document. You can rotate pages by setting rotation angle to 90,180 or 270 degrees. 

#### Swap Page

**SwapPages** operation allows to swap two pages positions within the source document. The result is a new document where two pages have their positions exchanged.

#### Extract Pages

**ExtractPages** feature allows to extract specified page or page ranges from source document. The result is a new document that contains only specified pages from the source document.

#### Change Pages Orientation

**ChangeOrientation** operation lets you set page orientation (portrait, landscape) for specific or all pages of the document.

## Document security operations

GroupDocs.Merger API allows to manage document password-protection through the following security operations:

*   Check for password-protection;
*   Set document password if document is not protected with password;
*   Update password if document is password-protected already;
*   Remove password if document is password-protected. 

## Document information extraction

GroupDocs.Merger allows to obtain basic information about source document - file type, size, pages count, page height and width etc.  
This may be quite useful for generating document preview.

## Preview document pages

Document preview feature allows to generate image representations of document pages. This may be helpful for better understanding about document content and its structure. Preview can be generated for all document pages (by default) or for specific page numbers or page range.

Supported image formats for document preview are:

*   PNG;
*   JPG;
*   BMP.

## Logging while processing document 

GroupDocs.Merger allows to log document manipulation processes info through [ILogger](https://apireference.groupdocs.com/net/merger/groupdocs.merger.logging/ilogger) interface. There is ability to use built-in [ConsoleLogger](https://apireference.groupdocs.com/net/merger/groupdocs.merger.logging/consolelogger) or implement own logging logic.
