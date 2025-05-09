using CommunityToolkit.Mvvm.Input;
using Practica_NavegacionGalerias_MarioLlamaGarcia.Models;

namespace Practica_NavegacionGalerias_MarioLlamaGarcia.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}