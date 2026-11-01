using CommunityToolkit.Mvvm.ComponentModel;

using FrostyMediaPlayer.Contracts.ViewModels;
using FrostyMediaPlayer.Core.Contracts.Services;
using FrostyMediaPlayer.Core.Models;

namespace FrostyMediaPlayer.ViewModels;

public partial class PlaylistsDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public PlaylistsDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
