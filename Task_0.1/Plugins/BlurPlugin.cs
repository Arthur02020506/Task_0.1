using System;

namespace  ImageProcessingFramework
{
    // Dummy blur plugin
    public class BlurPlugin : IPlugin
    {
        public string Name => "Blur";

        public void ApplyEffect(Image image, PluginParameters parameters)
        {
            int blurAmount = parameters.GetParameter<int>("BlurAmount");
            Console.WriteLine($"Applying blur of {blurAmount} pixels to {image.Name}");
            // Dummy logic to blur image
        }
    }
}
