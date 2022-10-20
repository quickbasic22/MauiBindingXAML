using Plugin.Maui.Audio;

namespace MauiBindingXAML;

public partial class MainPage : ContentPage
{
	int count = 0;
	IMap _map;

	public MainPage(IMap map)
	{
		InitializeComponent();
	   this._map = map;
		BindingContext = new ViewModels.MainPageViewModel();
	}

	private async void OnSoundClicked(object sender, EventArgs e)
	{
		
		var audio = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Alarm01.wav"));
		audio.Play();
		MauiAudio.MediaPlay media = new MauiAudio.MediaPlay();
		Location eustis = new Location(28.880883, -81.7073333);
		MapLaunchOptions options = new MapLaunchOptions();
		options.NavigationMode = NavigationMode.Bicycling;
		await _map.OpenAsync(eustis);
	}
}

