using IsoniaCore.Resources.Icons;
using IsoniaCore.ViewModels;
using IsoniaCore.Utilities;
using Avalonia.Controls;

namespace IsoniaCore.Resources.Controls;

public partial class ViewModelBaseIdentifier : UserControl
{
#if DEBUG
    private class ViewModelBasePreview : ViewModelBase
    {
        public ViewModelBasePreview()
        {
            Title = "Test Title";
            Icon = IconStore.ProjectIcon;
        }
    }
    public ViewModelBaseIdentifier()
    {
        InitializeComponent();
        this.OverrideDesignContext<ViewModelBasePreview>();
    }
#else
    public ViewModelBaseIdentifier()
    {
        InitializeComponent();
    }
#endif
}