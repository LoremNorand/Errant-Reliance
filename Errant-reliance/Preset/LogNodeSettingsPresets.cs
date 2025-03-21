using System.Collections.Generic;
using System.Text;

namespace EReliance.Preset
{
    public partial class LogNodeSettingsPresets
    {
        // Публичные статические свойства
        public static LogNodeSettingsPresets Instance
        {
            get => _instance;
        }


        // Приватные статические поля
        private static LogNodeSettingsPresets _instance = new LogNodeSettingsPresets();


        // Публичные свойства
        public Entity.LogNodeSettings this[string presetName]
        {
            get => _logNodeSettings[presetName];
            set => _logNodeSettings[presetName] = value;
        }


        // Приватные поля
        private Dictionary<string, Entity.LogNodeSettings> _logNodeSettings = 
            new Dictionary<string, Entity.LogNodeSettings>();


        // Конструктор
        private LogNodeSettingsPresets()
        {
            // Описано в LogNodeSettingsPresetsBuilder.cs
            InitializeDefaultPresets();
        }

        
        // Публичные методы
        public bool ContainsKey(string key)
        {
            return _logNodeSettings.ContainsKey(key);
        }

        public void Add(string key, Entity.LogNodeSettings value)
        {
            _logNodeSettings.Add(key, value);
        }

        public void Remove(string key)
        {
            _logNodeSettings.Remove(key);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var keyCollection = _logNodeSettings.Keys;
            foreach (string key in keyCollection)
            {
                sb.AppendLine(key);
            }
            return sb.ToString();
        }
    }

}
