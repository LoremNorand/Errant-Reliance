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

        public Entity.LogNodeSettings Settings
        {
            get => _settings;
            set => _settings = value;
        }

        private Entity.LogNodeSettings _settings;


        public void Log(string logType, string message)
        {

        }
    }
}
