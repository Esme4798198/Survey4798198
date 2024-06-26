namespace Survey4798198;

public partial class SurveysView : ContentPage
{
	public SurveysView()
	{
		InitializeComponent();
	}

    private async void AddSurveyButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SurveyDetailsView());
    }
}