using FrostyMediaPlayer.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FrostyMediaPlayer.Views;

public sealed partial class PlaylistsPage : Page
{
    public PlaylistsViewModel ViewModel
    {
        get;
    }

    public PlaylistsPage()
    {
        ViewModel = App.GetService<PlaylistsViewModel>();
        InitializeComponent();
    }
}
