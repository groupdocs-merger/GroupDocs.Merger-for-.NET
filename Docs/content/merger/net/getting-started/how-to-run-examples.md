---
id: how-to-run-examples
url: merger/net/how-to-run-examples
title: How to Run Examples
weight: 6
description: ""
keywords: 
productName: GroupDocs.Merger for .NET
hideChildren: False
---
{{< alert style="warning" >}}Before running an example make sure that GroupDocs.Merger has been installed successfully.{{< /alert >}}

We offer multiple solutions on how you can run GroupDocs.Merger examples, by building your own or using our back-end or front-end examples out-of-the-box.

Please choose one from the following list:


## Build project from scratch

*   Open Visual Studio and go to **File** -> **New** -> **Project**.
*   Select appropriate project type - Console App, ASP.NET Web Application etc.
*   Install **GroupDocs.Merger for .NET** from Nuget or official GroupDocs website following this [guide]({{< ref "merger/net/getting-started/installation.md" >}}).
*   Code your first application with **GroupDocs.Merger for .NET** like this    
    ```csharp
    // The path to the documents directory.
    string firstDocPath = @"C:\sample.docx"; // NOTE: Put here actual path for your document
    string secondDocPath = @"C:\sample2.docx"; // NOTE: Put here actual path for your document
    string outputPath = @"C:\output\result.docx";
    
    // Join two documents and save into result.docx.
    using (Merger merger = new Merger(firstDocPath))
    {
    	merger.Join(secondDocPath);
        merger.Save(outputPath);
    }    
    ```    
*   Build and Run your project. 
*   Signed document will appear inside *"C:\\output\\"* directory.

## Run back-end examples

The complete examples package of **GroupDocs.Merger** is hosted on [GitHub](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET). You can either download the ZIP file from [here](https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/archive/master.zip) or clone the repository of GitHub using your favourite git client.  
In case you download the ZIP file, extract the folders on your local disk. The extracted files and folders will look like following image:

![](merger/net/images/how-to-run-examples.png)

In extracted files and folders, you can find CSharp solution file. The project is created in **Microsoft Visual Studio 2019**. The **Resources** folder contains all the sample document and image files used in the examples.  
To run the examples, open the solution file in Visual Studio and build the project. To add missing references of **GroupDocs.Merger** see [Development Environment, Installation and Configuration]({{< ref "merger/net/getting-started/installation.md" >}}). All the functions are called from **RunExamples.cs**.
Un-comment the function you want to run and comment the rest.

![](merger/net/images/how-to-run-examples_1.png)

## Contribute

If you like to add or improve an example, we encourage you to contribute to the project. All examples in this repository are open source and can be freely used in your own applications.  
To contribute, you can fork the repository, edit the code and create a pull request. We will review the changes and include it in the repository if found helpful.
