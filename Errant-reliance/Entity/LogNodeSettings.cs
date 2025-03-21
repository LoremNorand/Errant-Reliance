using System.Text;

namespace EReliance.Entity
{
    public class LogNodeSettings
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
        public string Name { get => _name; set => _name = value; }


        // Публичные логические свойства
        public bool ParentLogging { get => _parentLogging; set => _parentLogging = value; }
        public bool NameLogging { get => _nameLogging; set => _nameLogging = value; }
        public bool TimeLogging { get => _timeLogging; set => _timeLogging = value; }
        public bool TypeLogging { get => _typeLogging; set => _typeLogging = value; }
        public bool MessageLogging { get => _messageLogging; set => _messageLogging = value; }
        public bool StackLogging { get => _stackLogging; set => _stackLogging = value; }
        public bool LevelLogging { get => _levelLogging; set => _levelLogging = value; }


        private string _name = "Безымянный узел";


        // Приватные логические поля
        private bool _parentLogging = true;
        private bool _nameLogging = true;
        private bool _timeLogging = true;
        private bool _typeLogging = true;
        private bool _messageLogging = true;
        private bool _stackLogging = true;
        private bool _levelLogging = true;


        // Конструкторы
        public LogNodeSettings(
            string name = "Безымянный узел",
            bool parentLogging = true,
            bool nameLogging = true,
            bool timeLogging = true,
            bool typeLogging = true,
            bool messageLogging = true,
            bool stackLogging = true,
            bool levelLogging = true
            )
        {
            Name = name;
            ParentLogging = parentLogging;
            NameLogging = nameLogging;
            TimeLogging = timeLogging;
            TypeLogging = typeLogging;
            MessageLogging = messageLogging;
            StackLogging = stackLogging;
            LevelLogging = _levelLogging;
        }

        public LogNodeSettings(string name, string presetName)
        {
            Name = name;
            AssignPreset(presetName);
        }


        // Публичные методы
        public void AssignPreset(string presetName)
        {
            string bufferName = Name;
            if (Preset.LogNodeSettingsPresets.Instance.ContainsKey(presetName))
            {
                LogNodeSettings preset = Preset.LogNodeSettingsPresets.Instance[presetName];
                ParentLogging = preset.ParentLogging;
                NameLogging = preset.NameLogging;
                TimeLogging = preset.TimeLogging;
                TypeLogging = preset.TypeLogging;
                MessageLogging = preset.MessageLogging;
                StackLogging = preset.StackLogging;
                LevelLogging = preset.LevelLogging;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EReliance.Entity.LogNodeSettings | Свойства узла {Name}");
            sb.AppendLine("  # ОСНОВНЫЕ СВОЙСТВА");
            sb.AppendLine($"    Имя узла: {Name}");
            sb.AppendLine("  # ЛОГИЧЕСКИЕ СВОЙСТВА");
            sb.AppendLine($"    Вывод родителя: {ParentLogging}");
            sb.AppendLine($"    Вывод имени: {NameLogging}");
            sb.AppendLine($"    Вывод времени: {TimeLogging}");
            sb.AppendLine($"    Вывод типа: {TypeLogging}");
            sb.AppendLine($"    Вывод сообщения: {MessageLogging}");
            sb.AppendLine($"    Вывод стека: {StackLogging}");
            return sb.ToString();
        }
    }
}
