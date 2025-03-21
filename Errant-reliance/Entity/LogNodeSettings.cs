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
        public string Parent { get => _parent; set => _parent = value; }
        public string Name { get => _name; set => _name = value; }

        // Публичные логические свойства
        public bool ParentLogging { get => _parentLogging; set => _parentLogging = value; }
        public bool NameLogging { get => _nameLogging; set => _nameLogging = value; }
        public bool TimeLogging { get => _timeLogging; set => _timeLogging = value; }
        public bool TypeLogging { get => _typeLogging; set => _typeLogging = value; }
        public bool MessageLogging { get => _messageLogging; set => _messageLogging = value; }
        public bool StackLogging { get => _stackLogging; set => _stackLogging = value; }


        // Приватные поля
        private string _parent = "Глобальное";
        private string _name = "Безымянный узел";

        // Приватные логические поля
        private bool _parentLogging = true;
        private bool _nameLogging = true;
        private bool _timeLogging = true;
        private bool _typeLogging = true;
        private bool _messageLogging = true;
        private bool _stackLogging = true;


        // Конструктор
        public LogNodeSettings(
            string parent = "Глобальное",
            string name = "Безымянный узел",
            bool parentLogging = true,
            bool nameLogging = true,
            bool timeLogging = true,
            bool typeLogging = true,
            bool messageLogging = true,
            bool stackLogging = true
            )
        {

        }


        // Публичные методы
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"EReliance.Entity.LogNodeSettings | Свойства узла {Name}");
            sb.AppendLine("  # ОСНОВНЫЕ СВОЙСТВА");
            sb.AppendLine($"    Имя узла: {Name}");
            sb.AppendLine($"    Родитель узла: {Parent}");
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
