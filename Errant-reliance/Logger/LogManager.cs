using System.Collections.Generic;

namespace EReliance.Logger
{
    public class LogManager
    {
        // Публичные свойства
        public static LogManager Instance
        {
            get => _instance ?? (_instance = new LogManager());
        }

        public Core.LogNode this[string name]
        {
            get => _logNodes[name];
            set
            {
                _logNodes[name] = value;
                _logNodes[name].Settings.Name = name;
            }
        }


        // Приватные поля
        private static LogManager _instance = new LogManager();
        private Dictionary<string, Core.LogNode> _logNodes = new Dictionary<string, Core.LogNode>();


        // Конструктор
        private LogManager() { }
    }
}
