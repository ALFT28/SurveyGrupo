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




}