# Thin .NET 8 console app/dotnet tools around IKVM cross-compiled .NET version of Saxon-HE 12.7 Java
These tools are .NET 8 console apps/a dotnet tools providing a thin .NET 8 wrapper around an IKVM cross-compiled version of Saxon HE 12.8 Java to perform XSLT 3.0 transformations or to run XQuery 3.1.

This is one of the sample projects outlining my successful attempt to apply https://github.com/ikvm-revived/ikvm and
https://github.com/ikvm-revived/ikvm-maven to use the open-source Saxon HE 12 Java XSLT 3.0, XQuery 3.1 and XPath 3.1 library in .NET 8 code.

Please understand that this is my own experiment, it uses the official Saxon HE 12.8 release from Maven, but the integration with IKVM and IKVM Maven is an experimental work of my own, not in any way an officially tested and supported product by Saxonica, the company that has produced Saxon.

So feel free to use to try and use it under the Mozilla Public License 2.0. 

Understand that this is work in progress and kind of experimental, I don't have access to a complete test suite of unit tests to rigorously test this, I nevertheless feel it can be useful for folks to at least know about this option to run [XSLT 3.0](https://www.w3.org/TR/xslt-30/) with .NET 8, without depending on the so far commercial only SaxonCS from Saxonica.

Known issues: I have created the project with VS 2022 Community Edition on Windows, apps built that way could be deployed and run successfully under Linux or Mac; also, the latest https://github.com/ikvm-revived/ikvm-maven does seem to work on a Mac, so in experiments of your own you should be able to develop and build on Windows and MacOS.