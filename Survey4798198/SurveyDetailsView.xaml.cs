namespace Survey4798198;


public partial class SurveyDetailsView : ContentPage
{
    /// <summary>
    /// teams es un arreglo de cadenas, declarado como private readonly, lo que significa que solo se puede modificar una vez
    /// y solo es accesible dentro de la clase donde se define. El arreglo contiene una lista predefinida de nombres de equipos de f�tbol.
    /// </summary>
    private readonly string[] teams =
    {
        "America Lima",
        "America",
        "Boca Juniors",
        "Caracas FC",
        "Colo-Colo",
        "Pe�arol",
        "Real Madrid",
        "Saprissa",
    };

    /// <summary>
    /// SurveyDetailsView es un m�todo especial que se llama cuando se crea una nueva instancia de la clase SurveyDetailsView. Dentro del constructor
    /// se llama al m�todo InitializeComponent para inicializar todos los componentes de la interfaz de usuario
    /// </summary>
	public SurveyDetailsView()
	{
		InitializeComponent();
	}


    /// <summary>
    /// Button_Clicked es un evento que se ejecuta cuando se hace clic en un bot�n.
    ///  Muestra una hoja de acciones (ActionSheet) con una lista de equipos de f�tbol para que el usuario seleccione uno
    ///  Si el usuario selecciona un equipo, el texto del label FavoriteTeamLabel se actualiza con el equipo seleccionado.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literal.FavoriteTeamTitle, null, null, teams);
        if(!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }
    }


    /// <summary>
    /// Button_Clicked_1 es un evento que se ejecuta cuando se hace clic en un bot�n. 
    /// Verifica si los campos de texto para el nombre y el equipo favorito que no esten vac�os.
    /// Si ambos campos tienen datos, crea un nuevo objeto Surveys con la informaci�n ingresada y este
    /// Env�a este objeto a trav�s de MessagingCenter y luego navega hacia atr�s en la pila de navegaci�n
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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