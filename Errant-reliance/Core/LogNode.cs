using System.Text;

namespace EReliance.Core
{
    // public protected internal private new abstract virtual override sealed static readonly extern unsafe volatile async
    public class LogNode
    {
        //---
        //Nested classes, enums, delegates and events.
        //Static, const and readonly fields
        //Fields, properties
        //Constructors, finalizers
        //Methods
        //---
        //public
        //internal
        //protected internal
        //protected
        //private
        //---

        // Публичные свойства
        public Entity.LogNodeSettings Settings
        {
            get => _settings;
            set => _settings = value;
        }

        public int Level
        {
            get
            {
                if (_parent == null)
                    return 0;
                return _parent.Level + 1;
            }
        }

        public LogNode Parent
        {
            get => (_parent != null) ? _parent : null;
            set => _parent = value;
        }


        // Приватные поля
        private int _level;
        private LogNode _parent;
        private Entity.LogNodeSettings _settings;


        public void Log(string logType, string message)
        {

        }

    }
}
