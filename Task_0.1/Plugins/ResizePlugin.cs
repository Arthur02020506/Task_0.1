using System;

namespace ImageProcessingFramework
{
    // Dummy resize plugin
    public class ResizePlugin : IPlugin
    {
        public string Name => "Resize";

        public void ApplyEffect(Image image, PluginParameters parameters)
        {
            int newSize = parameters.GetParameter<int>("Size");
            Console.WriteLine($"Resizing {image.Name} to {newSize} pixels");
            // Dummy logic to resize image
        }
    }
}
