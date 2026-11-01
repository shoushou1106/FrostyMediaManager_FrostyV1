using CommunityToolkit.WinUI.UI.Controls;

using FrostyMediaPlayer.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FrostyMediaPlayer.Views;

public sealed partial class FrostyConfigPage : Page
{
    public FrostyConfigViewModel ViewModel
    {
        get;
    }

    public FrostyConfigPage()
    {
        ViewModel = App.GetService<FrostyConfigViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
