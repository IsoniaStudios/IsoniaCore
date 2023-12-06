namespace IsoniaCore.Resources.Controls.Dock;

public interface IDockRoot
{
    IList<IDock> Children { get; }
}
