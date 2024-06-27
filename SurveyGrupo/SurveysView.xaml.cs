namespace SurveyGrupo;

//Se va a subir de nuevo los cambios

public partial class SurveysView : ContentPage
{

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

	

	
}