
namespace ImageProcessingFramework
{
    // Plugin interface for all image effects
    public interface IPlugin
    {
        string Name { get; }
        void ApplyEffect(Image image, PluginParameters parameters);
    }

}
