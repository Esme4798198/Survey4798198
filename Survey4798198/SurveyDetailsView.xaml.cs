namespace Survey4798198;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
        "America Lima",
        "America",
        "Boca Juniors",
        "Caracas FC",
        "Colo-Colo",
        "Peñarol",
        "Real Madrid",
        "Saprissa",
    };
	public SurveyDetailsView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literal.FavoriteTeamTitle, null, null, teams);
        if(!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {

        //Evaluamos si los datos estan completos
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }
        //Creamo l nuevo objeto de tipoSurvey
        var newSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };
        //Publicamos el mensjae con el objeto de encuesta como argumento

        MessagingCenter.Send((ContentPage)this,
        Messages.NewSurveyComplete, newSurvey);

        await Navigation.PopAsync();    
    }

}