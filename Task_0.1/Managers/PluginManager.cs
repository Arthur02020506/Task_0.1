using System.Collections.Generic;

namespace ImageProcessingFramework
{
    public class PluginManager
    {
        private List<IPlugin> plugins;

        public PluginManager()
        {
            plugins = new List<IPlugin>();
        }

        public void AddPlugin(IPlugin plugin)
        {
            plugins.Add(plugin);
        }

        public void RemovePlugin(IPlugin plugin)
        {
            plugins.Remove(plugin);
        }

        public IEnumerable<IPlugin> GetPlugins()
        {
            return plugins;
        }
    }
}
