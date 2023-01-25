# PDFInspector
A quick and simple way (with free code sample) to check if a PDF file contains images and/or text using Syncfusion PDF class library for .NET

## Introduction
If you often work with PDF files, you've probably already heard of Syncfusion Essential Studio, a .NET-based software product providing solutions to most of the complex problems faced during application development. Among the many components available the product includes a neat PDF framework, a feature-rich .NET PDF class library developed with 100% managed C# code that can be used to create, read and write PDF files using Windows Forms, WPF, ASP.NET Web Forms, ASP.NET MVC, ASP.NET Core, Blazor, UWP, Xamarin, Flutter applications and Unity platform without any external dependency (no Adobe Acrobat required).

I have recently used Syncfusion's PDF framework to solve a task I was given a few days ago: determine if a bunch of PDF files contain images, text, or both. Needless to say, the files were actually a lot (more than 500K), so this couldn't be done manually. In this post, I'll share the source code I have used to deal with this issue.

## Packages
The project requires the following NuGet packages:
* [Syncfusion.Pdf.Net.Core](https://www.nuget.org/packages/Syncfusion.Pdf.Net.Core?WT.mc_id=DT-MVP-5003202)
* [Syncfusion.Pdf.Imaging.Net.Core](https://www.nuget.org/packages/Syncfusion.Pdf.Imaging.Net.Core/?WT.mc_id=DT-MVP-5003202)

The first package contains the base classes to handle PDF files, while the latter contains specific modules and extension methods to deal with PDF-embedded images.

**NOTE**: For both packages I have used the 20.4.0.44 version, which was the latest at the time of writing (and fully compatible with .NET 6 and .NET 7): feel free to update it to a newer version!

## Documentation
For additional info regarding the source code, read [this post](https://www.ryadel.com/en/c-sharp-pdf-contains-images-text-net/) on my blog!
