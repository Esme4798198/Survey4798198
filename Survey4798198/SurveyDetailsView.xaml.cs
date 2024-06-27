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

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}