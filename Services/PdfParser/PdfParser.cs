using System.Globalization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using UniversityRanking.DTO;

namespace UniversityRanking.Services.PdfParser;

public static class PdfParser
{
    private const string FilePath = "Services/PdfParser/report.pdf";
    private static BaseFont _titleFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    private static BaseFont _contentFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
    
    public static byte[] FromReportToPdf(ReportParser report)
    {
        using MemoryStream ms = new MemoryStream();
    
        Document doc = new(PageSize.A4, 5f, 5f, 5f, 5f);

        PdfWriter writer = PdfWriter.GetInstance(doc, ms);
        doc.Open();

        foreach (var mainSubject in report.MainSubject)
        {
            Paragraph title = new($"{mainSubject.Title} report", new(_titleFont, 24f, Font.UNDERLINE));
            doc.Add(title);
        
            doc.Add(new Paragraph("\n"));

            PdfPTable table = new(2);
            table.WidthPercentage = 100;
            
            foreach (var rep in report.Report.Where(r => r.MainSubjectId == mainSubject.Id))
            {
                table.AddCell(new PdfPCell(new Phrase("Title", new(_contentFont, 14))));
                table.AddCell(new PdfPCell(new Phrase(rep.Title, new(_contentFont, 14))));
                table.AddCell(new PdfPCell(new Phrase("Date of the event", new(_contentFont, 14))));
                table.AddCell(new PdfPCell(new Phrase(rep.Date.ToString(CultureInfo.CurrentCulture),
                    new(_contentFont, 14))));
                table.AddCell(new PdfPCell(new Phrase("Description", new(_contentFont, 14))));
                table.AddCell(new PdfPCell(new Phrase(rep.Description, new(_contentFont, 14))));

                PdfPCell emptyCell = new PdfPCell(new Phrase(" "));
                emptyCell.Colspan = 2;
                emptyCell.Border = PdfPCell.NO_BORDER;
                table.AddCell(emptyCell);
            }
            
            doc.Add(table);
        }

        doc.Close();
        return ms.ToArray();
    }

}