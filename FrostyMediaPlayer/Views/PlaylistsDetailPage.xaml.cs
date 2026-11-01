using CommunityToolkit.WinUI.UI.Animations;

using FrostyMediaPlayer.Contracts.Services;
using FrostyMediaPlayer.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace FrostyMediaPlayer.Views;

public sealed partial class PlaylistsDetailPage : Page
{
    public PlaylistsDetailViewModel ViewModel
    {
        get;
    }

    public PlaylistsDetailPage()
    {
        ViewModel = App.GetService<PlaylistsDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();

            if (ViewModel.Item != null)
            {
                navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
            }
        }
    }
}
