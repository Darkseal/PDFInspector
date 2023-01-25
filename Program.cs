using Syncfusion.Pdf;
using Syncfusion.Pdf.Exporting;
using Syncfusion.Pdf.Parsing;

//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider
    .RegisterLicense("<LICENSE-KEY>"); // TODO: Insert your license key here

List<string> filePathList = GetFilePathList(); // TODO: implement this method 
                                      //   to retrieve a list of paths for the PDF files.

var allowedPdfExtensions = new[] { "pdf" };

foreach (var path in filePathList)
{
    var pdfType = "undefined";

    if (string.IsNullOrEmpty(path) || !File.Exists(path))
        continue;

    try
    {
        var ext = Path.GetExtension(path);
        if (!string.IsNullOrEmpty(ext)
            && allowedPdfExtensions.Contains(ext.TrimStart('.'),
                StringComparer.InvariantCultureIgnoreCase))
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var loadedDocument = new PdfLoadedDocument(stream);
            var loadedPages = loadedDocument.Pages;
            int charCount = 0;
            int imageCount = 0;
            foreach (PdfLoadedPage loadedPage in loadedPages)
            {
                var txt = loadedPage.ExtractText();
                if (!string.IsNullOrEmpty(txt))
                    charCount += txt.Length;
                var imagesInfo = loadedPage.GetImagesInfo();
                if (imagesInfo != null)
                    imageCount += imagesInfo.Length;
            }
            loadedDocument.Close(true);

            if (charCount > 0 && imageCount == 0)
                pdfType = "text only";
            else if (charCount == 0 && imageCount > 0)
                pdfType = "images only";
            else if (charCount > 0 && imageCount > 0)
                pdfType = "text and images";
            else
                pdfType = "no text and no images";
        }
        else
            pdfType = "non-PDF file";
    }
    catch (Exception e)
    {
        pdfType = $"error: {e.Message}";
    }

    DoSomething(pdfType); // TODO: do something with the [pdfType] variable
}

static List<string> GetFilePathList() 
    => throw new NotSupportedException("TODO");
static List<string> DoSomething(string pdfType) 
    => throw new NotSupportedException("TODO");

