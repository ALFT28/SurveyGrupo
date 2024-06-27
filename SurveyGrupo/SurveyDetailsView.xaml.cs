
namespace SurveyGrupo;

public partial class SurveyDetailsView : ContentPage
{
	private readonly string[] teams =
	{
		"Alianza Lima",
		"America",
		"Boca Juniors",
		"Caracas FC",
		"colo-colo",
		"Peñarol",
		"Real Madrid",
		"Saprissa"
	};

	public SurveyDetailsView()
	{
		InitializeComponent();
	}

    private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
    {
		var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTitle, null, null, teams);
        if(!String.IsNullOrWhiteSpace(favoriteTeam))
		{
			FavoriteTeamLabel.Text = favoriteTeam;
		}
    }

  

    private async void Button_Clicked(object sender, EventArgs e)
    {
        //Evaluamos si los datos estan completos
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }

        //Creamos el nuevo objeto de tipo Survey
        var newSurvey = new Survey()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };

        //Publicamos el mensaje con el objeto de encuesta como argumento 
        MessagingCenter.Send((ContentPage)this,
        Messages.NewSurveyComplete, newSurvey);

        //Removemos la pagina la pagina de la pila de navegacion para regresar inmediatamente
        await Navigation.PopAsync();
    }
}