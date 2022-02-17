using Prism.Commands;

namespace PrismWPFHoneys.Core.Types.Interfaces
{
    public interface IApplicationCommands
    {
        CompositeCommand SelectedApplicationCommand { get; }
        CompositeCommand NavigationNavigateCommand { get; }
    }

    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand SelectedApplicationCommand { get; } = new CompositeCommand();
        public CompositeCommand NavigationNavigateCommand { get; } = new CompositeCommand();

    }
}
