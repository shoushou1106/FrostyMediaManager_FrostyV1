using FrostyMediaPlayer.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FrostyMediaPlayer.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class PlayQueuePage : Page
{
    public PlayQueueViewModel ViewModel
    {
        get;
    }

    public PlayQueuePage()
    {
        ViewModel = App.GetService<PlayQueueViewModel>();
        InitializeComponent();
    }
}
