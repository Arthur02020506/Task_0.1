// Parameters class to hold plugin parameters
using System.Collections.Generic;

namespace ImageProcessingFramework
{
    public class PluginParameters
    {
        public Dictionary<string, object> Parameters { get; set; }

        public PluginParameters()
        {
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string key, object value)
        {
            Parameters[key] = value;
        }

        public T GetParameter<T>(string key)
        {
            if (Parameters.ContainsKey(key))
            {
                return (T)Parameters[key];
            }
            throw new KeyNotFoundException($"Parameter {key} not found");
        }
    }
}