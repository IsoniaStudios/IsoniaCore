namespace IsoniaCore.DataTypes;

public class Suppressor : IDisposable
{
    private bool disposed = false;
    private readonly Observable observable;

    public Suppressor(Observable observable)
    {

        this.observable = observable;
        observable.suppressPropertyChanged = true;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                observable.suppressPropertyChanged = true;
            }

            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
