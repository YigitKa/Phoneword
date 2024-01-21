namespace Phoneword;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count > 0)
			CounterBtn.Text = $"{count} kez tıklandı :)"; // build test

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


