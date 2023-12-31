﻿using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace IsoniaCore.DataTypes;

[Serializable]
public class Observable : INotifyPropertyChanged
{
    [field: NonSerialized]
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Send property changed event, regardless if value is updated or not
    /// </summary>
    /// <param name="name"></param>
    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        if (suppressPropertyChanged)
            return;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    /// <summary>
    /// Send property event if value is updated
    /// </summary>
    /// <returns></returns>
    protected bool OnPropertyChanged<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (suppressPropertyChanged)
            return false;

        if (!EqualityComparer<T>.Default.Equals(field, newValue))
        {
            field = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
        return false;
    }

    /// <summary>
    /// Send property event for property
    /// </summary>
    /// <returns></returns>
    protected void OnPropertyChanged<T>(string propertyName)
    {
        if (suppressPropertyChanged)
            return;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    internal bool suppressPropertyChanged = false;
    public Suppressor Suppress()
    {
        return new Suppressor(this);
    }
}
