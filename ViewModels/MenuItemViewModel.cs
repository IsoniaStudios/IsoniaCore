using System.Collections.ObjectModel;
using System.Windows.Input;
using IsoniaCore.DataTypes;
using Avalonia.Media;
using Avalonia.Input;

namespace IsoniaCore.ViewModels;

public class MenuItemViewModel : Observable
{
    private string title = string.Empty;
    private StreamGeometry? icon = null;
    private ICommand? command = null;
    private KeyGesture? inputGesture;

    public string Title
    {
        get => title;
        protected set => OnPropertyChanged(ref title, value);
    }
    public StreamGeometry? Icon
    {
        get => icon;
        protected set => OnPropertyChanged(ref icon, value);
    }

    public ICommand? Command
    {
        get => command;
        protected set => OnPropertyChanged(ref command, value);
    }
    public KeyGesture? InputGesture
    {
        get => inputGesture;
        protected set => OnPropertyChanged(ref inputGesture, value);
    }

    public ObservableCollection<MenuItemViewModel> SubItems { get; }

    public override string ToString()
    {
        return Title;
    }

    public MenuItemViewModel(string title, StreamGeometry? icon = null, ICommand? command = null, KeyGesture? inputGesture = null, params MenuItemViewModel[] subItems)
    {
        Title = title;
        Icon = icon;
        Command = command;
        InputGesture = inputGesture;

        SubItems = new(subItems);
    }
}
