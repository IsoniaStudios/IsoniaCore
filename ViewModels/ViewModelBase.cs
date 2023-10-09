using IsoniaCore.DataTypes;

namespace IsoniaCore.ViewModels
{
    public abstract class ViewModelBase : Observable
    {
        private string title = string.Empty;
        private string subTitle = string.Empty;
        private bool isEnabled = true;

        public string Title
        {
            get => title;
            protected set => OnPropertyChanged(ref title, value);
        }
        public string SubTitle
        {
            get => subTitle;
            protected set => OnPropertyChanged(ref subTitle, value);
        }
        public bool IsEnabled
        {
            get => isEnabled;
            set => OnPropertyChanged(ref isEnabled, value);
        }
    }
}
