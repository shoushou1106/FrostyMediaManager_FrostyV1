using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using FrostyMediaPlayer.Contracts.ViewModels;
using FrostyMediaPlayer.Core.Contracts.Services;
using FrostyMediaPlayer.Core.Models;

namespace FrostyMediaPlayer.ViewModels;

public partial class LibraryViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public LibraryViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
