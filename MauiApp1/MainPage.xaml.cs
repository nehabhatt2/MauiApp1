namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		
			CounterBtn.Text = $"Welcome To GCOB!";
		

		SemanticScreenReader.Announce(CounterBtn.Text);
        await Shell.Current.GoToAsync("//Search");
    }
}

