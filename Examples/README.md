# GroupDocs.Merger for .NET Examples

This package contains C# Example Project for [GroupDocs.Merger for .NET](https://products.groupdocs.com/merger/net) and sample input templates used in the examples.

<p align="center">
  <a title="Download complete GroupDocs.Merger examples, plugins and showcase projects for .NET" href="https://github.com/groupdocs-merger/GroupDocs.Merger-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

## How to Run the Examples in Visual Studio?

Follow the given steps to proceed with project build:

* Extract the downloaded project and open the solution file in Visual Studio
* Right click on solution and press "Enable NuGet package Restore"
* Build the project.

In other case, it is possible that Visual Studio is unable to automatically add APIs references due to Visual Studio version differences. In this case, please add references of missing APIs manually.

## How to Run the Examples in Docker container?

* Navigate into Examples directory
* Build an image
  `docker build --pull -t merger:examples .`
* Run a container
  * Windows Command Line (CMD): `docker run --rm -it -v %cd%:/examples/Results merger:examples`
  * Powershell: `docker run --rm -it -v ${PWD}:/examples/Results merger:examples`
  * On Linux: `docker run --rm -it -v $(pwd):/examples/Results merger:examples`

For more details, visit  [How to Run Examples](https://docs.groupdocs.com/display/mergernet/How+to+Run+Examples).
