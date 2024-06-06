using System;

namespace ImageProcessingFramework
{
    // Dummy grayscale plugin
    public class GrayscalePlugin : IPlugin
    {
        public string Name => "Grayscale";

        public void ApplyEffect(Image image, PluginParameters parameters)
        {
            Console.WriteLine($"Converting {image.Name} to grayscale");
            // Dummy logic to convert image to grayscale
        }
    }
}
