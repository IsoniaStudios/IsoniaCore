namespace IsoniaCore.Resources.Converters;

public sealed class BooleanInverterConverter : BooleanConverter<bool>
{
    public BooleanInverterConverter() : base(false, true) { }
}
