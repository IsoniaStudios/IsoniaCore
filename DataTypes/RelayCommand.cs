using System.Windows.Input;

namespace IsoniaCore.DataTypes;

public sealed class RelayCommand : RelayCommand<object>
{
    public RelayCommand(Action<object?> execute, Func<object?, bool> canExecute) : base(execute, canExecute)
    {
    }
    public RelayCommand(Action<object?> execute, bool canExecute = true) : base(execute, (o) => canExecute)
    {
    }
}

public class RelayCommand<T> : ICommand
{
    private readonly Action<T?> execute;
    private readonly Func<T?, bool> canExecute;

    public RelayCommand(Action<T?> action, Func<T?, bool> enabled)
    {
        execute = action;
        canExecute = enabled;
    }
    public RelayCommand(Action<T?> action, bool enabled = true)
    {
        execute = action;
        canExecute = (o) => enabled;
    }

    public event EventHandler? CanExecuteChanged;

    public bool CanExecute(object? parameter) => canExecute(arg: (T?)parameter);

    public void Execute(object? parameter) => execute(obj: (T?)parameter);
}
