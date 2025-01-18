using Newtonsoft.Json;

namespace MauiAppD;

public partial class NewPage2 : ContentPage
{
    public List<ReportData> Reports { get; set; }
    public NewPage2()
    {
        InitializeComponent();
        Reports = new List<ReportData>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Reports = LoadReports();
        DisplayReports();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage3());
    }

    private List<ReportData> LoadReports()
    {

        return InMemoryDatabase.ReportDataTable;
    }

    private void DisplayReports()
    {

        ReportStackLayout.Children.Clear();

  
        foreach (var report in Reports)
        {
            StackLayout stackLayout = new StackLayout
            {
            };

            stackLayout.Children.Add(new Label
            {
                Text = $"{report.ReportName}",
                FontSize = 20,
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.Start
            });

            stackLayout.Children.Add(new Label
            {
                Text = $"Opiekun: {report.GuardianName}",
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.Start
            });

            stackLayout.Children.Add(new Label
            {
                Text = $"Data generacji: {report.ReportGenerationDate:dd-MM-yyyy HH:mm}",
                TextColor = Colors.Black,
                HorizontalOptions = LayoutOptions.Start
            });


            ReportStackLayout.Children.Add(stackLayout);
        }
    }
}