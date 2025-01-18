using Newtonsoft.Json;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.IO;

namespace MauiAppD;

public partial class NewPage3 : ContentPage
{
    public string ReportName { get; set; }
    public string GuardianName { get; set; }
    public DateTime ReportGenerationDate { get; set; }
    public NewPage3()
	{
		InitializeComponent();
	}

    private void Save_Clicked(object sender, EventArgs e)
    {
      
        ReportName = "Raport Finansowy Jan Kowalski";
        GuardianName = "Pracownik1";
        ReportGenerationDate = DateTime.Now;

        var reportData = new ReportData
        {
            ReportName = ReportName,
            GuardianName = GuardianName,
            ReportGenerationDate = ReportGenerationDate
        };

       
        InMemoryDatabase.ReportDataTable.Add(reportData);

     
        DisplayAlert("Sukces", "Dane raportu zosta³y zapisane do bazy danych.", "OK");
    }
    private void Download_ClickedAsync(object sender, EventArgs e)
    {
        string filePath = GeneratePdfReport();
        DisplayAlert("Sukces", $"Raport zosta³ zapisany jako PDF: {filePath}", "OK");
    }

    private string GeneratePdfReport()
    {
        
        var pdfDocument = new PdfDocument();
        var page = pdfDocument.AddPage();
        var graphics = XGraphics.FromPdfPage(page);
        var font = new XFont("Verdana", 12);
        XFont boldFont = new XFont("Verdana", 12, XFontStyle.Bold);

      
        double margin = 40;
        double yPos = margin;

        graphics.DrawString("Raport Finansowy", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;

        graphics.DrawString("Jan Kowalski", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;

        graphics.DrawString("Numer Identyfikacji Podatkowej: PL1234567890", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;

        graphics.DrawString("Data raportu: 12 stycznia 2025", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;

        graphics.DrawString("Dane Osobowe", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;

        graphics.DrawString("Imiê: Jan", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Nazwisko: Kowalski", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Adres: Warszawa, ul. Nowa 1", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Telefon: +48 123 456 789", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("E-mail: jan.kowalski@example.com", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Data urodzenia: 01.01.1980", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        graphics.DrawString("Saldo Konta", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Saldo konta: 10000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Limit kredytowy: 5000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        graphics.DrawString("Kredyty", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Id: 1", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Kwota: 5000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Data pocz¹tkowa: 2022-01-01", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Data koñcowa: 2027-01-01", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        graphics.DrawString("Historia Transakcji", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Id: 1", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Kwota: 200.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Data transakcji: 2023-11-20", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Typ: Wp³ata", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        graphics.DrawString("Przychody i Wydatki", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Przychody roczne: 50000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Wydatki roczne: 30000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Zobowi¹zania podatkowe: 5000.00 PLN", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Ulgi podatkowe: 1000.00 PLN (Ulga na dziecko)", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        graphics.DrawString("Podsumowanie", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Typ opodatkowania: Podatek liniowy", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Podpis osoby odpowiedzialnej:", boldFont, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("......................................................", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 20;
        graphics.DrawString("Data: ............................................", font, XBrushes.Black, new XPoint(margin, yPos));
        yPos += 30;
        
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RaportFinansowy.pdf");
        pdfDocument.Save(filePath);

        return filePath;
    }
}