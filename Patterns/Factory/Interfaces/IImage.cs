namespace Patterns.Factory.Interfaces
{
    public interface IImage
    {
        string Name { get; set; }
        string Description { get; set; }
        Byte[] Data { get; set; }
        DateTime DateTime { get; set; }
        IExtension Extension { get; set; }
    }
}
