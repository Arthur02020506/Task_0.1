
namespace ImageProcessingFramework
{
    // Image class to store image data and apply effects
    public class Image
    {
        public string Name { get; set; }
        // Simulated image data
        public byte[] Data { get; set; }

        public Image(string name, byte[] data)
        {
            Name = name;
            Data = data;
        }

        public void ApplyEffect(IPlugin plugin, PluginParameters parameters)
        {
            plugin.ApplyEffect(this, parameters);
        }
    }
 
}
