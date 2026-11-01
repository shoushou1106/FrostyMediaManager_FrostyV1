using FrostyMediaPlayer.Core.Models;

namespace FrostyMediaPlayer.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetListDetailsDataAsync();

    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();

    Task<IEnumerable<SampleOrder>> GetGridDataAsync();
}
