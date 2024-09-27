using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Document = iTextSharp.text.Document;
using iTextSharp.text;
using PageSize = iTextSharp.text.PageSize;
using Paragraph = iTextSharp.text.Paragraph;

namespace TraversalCoreProje.Controllers;

public class PdfReportController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult StaticPdfReport()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);
        Document document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        document.Open();
        Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
        document.Add(paragraph);
        document.Close();
        return File("/pdfreports/dosya1.pdf","application/pdf","dosya1.pdf");
    }

    public IActionResult StaticCustomerReport()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);
        Document document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        document.Open();

        PdfPTable pdfPTable = new PdfPTable(3);
        pdfPTable.AddCell("Misafir Adı");
        pdfPTable.AddCell("Misafir Soyadı");
        pdfPTable.AddCell("Misafir Tc");
        
        pdfPTable.AddCell("Eylül");
        pdfPTable.AddCell("Yücedağ");
        pdfPTable.AddCell("34464542354");
        
        pdfPTable.AddCell("KEmal");
        pdfPTable.AddCell("Yıldız");
        pdfPTable.AddCell("12345678765");
        
        pdfPTable.AddCell("Mehmet");
        pdfPTable.AddCell("Demiral");
        pdfPTable.AddCell("99345676597");

        document.Add(pdfPTable);
        document.Close();
        return File("/pdfreports/dosya2.pdf","application/pdf","dosya2.pdf");
        
    }
    
}