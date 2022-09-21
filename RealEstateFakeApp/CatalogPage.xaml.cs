namespace RealEstateFakeApp;

public partial class CatalogPage : ContentPage
{
	public CatalogPage()
	{
		InitializeComponent();
		BindingContext = new BuildingViewModel();

    }
}
