using CommunityToolkit.Mvvm.Input;
using S8_P4.Models;

namespace S8_P4.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}