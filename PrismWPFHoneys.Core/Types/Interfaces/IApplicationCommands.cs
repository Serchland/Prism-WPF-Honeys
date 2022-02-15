using Prism.Commands;

namespace PrismWPFHoneys.Core.Types.Interfaces
{
    public interface IApplicationCommands
    {
        //CompositeCommand SelectedApplicationCommand { get; }
        CompositeCommand NavigationCommand { get; }
    }

    public class ApplicationCommands : IApplicationCommands
    {
        //public CompositeCommand SelectedApplicationCommand { get; } = new CompositeCommand();
        public CompositeCommand NavigationCommand { get; } = new CompositeCommand();

    }
}
