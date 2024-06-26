namespace SurveyGrupo;


public partial class SurveysView : ContentPage
{

	private readonly string[] teams = { "Real Madrid", "Barcelona", "Manchester City", "AC Milán" , "Bayern Munich" , "Manchester United"};

	public SurveysView()
	{
		InitializeComponent();
	}



	//Button agregado para navegar a la pagina detalle 
	private async void AddSurveyButton_Clicked(object sender, EventArgs e)
	{
		//Codigo para ver la pagina de los detalles - Agregado por Marcos
		await Navigation.PushAsync(new SurveyDetailsView());
	}

	private async void FavoriteTeamButton_Clicked (object sender , EventArgs e)
	{
		var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTitle, null, null, teams);
		if (!string.IsNullOrWhiteSpace(favoriteTeam))
		{
			FavoriteTeamLabel.Text = favoriteTeam;
		}
	}

	private async void OkButton_Clicked(object sender,EventArgs e)
	{
		//Evaluamos si los datos estan completos
		if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
		{
			return;
		}

		//Creamos el nuevo objeto de tipo Survey
		var newSurvey = new Surveys()
		{
			Name = NameEntry.Text,
			Birthdate = BirthdatePicker.Date,
			FavoriteTeam = FavoriteTeamLabel.Text
		};

		//Publicamos el mensaje con el objeto de encuesta como argumento 
		MessaginCenter.Send((ContentPage)this, Messages.NewSurveyComplete, new Survey);

		//Removemos la pagina la pagina de la pila de navegacion para regresar inmediatamente
		await Navigation.PopAsync();
	}
}