using System;

namespace ImageProcessingFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            byte[] imageData = new byte[] { 1, 2, 3, 4, 5 };

            // Create images
            Image image1 = new Image("Image1", imageData);
            Image image2 = new Image("Image2", imageData);
            Image image3 = new Image("Image3", imageData);

            // Create plugin manager and add plugins
            PluginManager pluginManager = new PluginManager();
            pluginManager.AddPlugin(new ResizePlugin());
            pluginManager.AddPlugin(new BlurPlugin());
            pluginManager.AddPlugin(new GrayscalePlugin());

            // Apply effects to images
            PluginParameters resizeParams = new PluginParameters();
            resizeParams.AddParameter("Size", 100);

            PluginParameters blurParams = new PluginParameters();
            blurParams.AddParameter("BlurAmount", 2);

            PluginParameters grayscaleParams = new PluginParameters();

            image1.ApplyEffect(new ResizePlugin(), resizeParams);
            image1.ApplyEffect(new BlurPlugin(), blurParams);

            image2.ApplyEffect(new ResizePlugin(), resizeParams);

            PluginParameters resizeParamsForImage3 = new PluginParameters();
            resizeParamsForImage3.AddParameter("Size", 150);

            PluginParameters blurParamsForImage3 = new PluginParameters();
            blurParamsForImage3.AddParameter("BlurAmount", 5);

            image3.ApplyEffect(new ResizePlugin(), resizeParamsForImage3);
            image3.ApplyEffect(new BlurPlugin(), blurParamsForImage3);
            image3.ApplyEffect(new GrayscalePlugin(), grayscaleParams);

            Console.WriteLine("Image processing complete.");
        }
    }
}
