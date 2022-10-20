using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;

namespace MauiBindingXAML.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async Task SoundMaker()
        {
            // Microsoft.Maui.Media.TextToSpeech.SpeakAsync("You've reached end of line, buddy!");
            var audio = AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Alarm01.wav"));
            audio.Play();
        }
    }
}
