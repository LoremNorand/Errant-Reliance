using System.Diagnostics;
using System.Text;

namespace EReliance.Utility
{
    internal static class LogAssembler
    {
        public static string AssembleMessage(Core.LogNode logNode, string[] meta)
        {
            StringBuilder sb = new StringBuilder();
            string shift = "".PadLeft(logNode.Level * Core.RelianceConfig.TAB_SIZE);
            string time = (logNode.Settings.TimeLogging) ? $"{TimeAssembler.AssembleTime()} | " : "";
            string name = (logNode.Settings.NameLogging) ? $"{logNode.Settings.Name} | " : "";
            string parent = (logNode.Settings.ParentLogging) ? $"Р: {logNode.Parent.Settings.Name} | " : "";
            string level = (logNode.Settings.LevelLogging) ? $"У: {logNode.Level} | " : "";
            string type = (logNode.Settings.TypeLogging) ? $"Т: {meta[0]} | " : "";
            string stack = (logNode.Settings.StackLogging) ? $"Стек:\n{meta[1]}" : "";
            string message = (logNode.Settings.MessageLogging) ? $"Сообщение: {meta[2]} " : "";
            sb.Append(shift); sb.AppendLine("(");
            sb.Append(shift); sb.AppendLine($"{time}{name}{parent}{level}{type}");
            sb.Append(shift); sb.AppendLine($"{stack}");
            sb.Append(shift); sb.AppendLine($"{message}");
            sb.Append(shift); sb.AppendLine(")");
            return sb.ToString();
        }

        public static string AssembleMessageHTML(Core.LogNode logNode, string[] meta)
        {
            StringBuilder sb = new StringBuilder();
            string shift = "".PadLeft(logNode.Level * Core.RelianceConfig.TAB_SIZE);
            string time = (logNode.Settings.TimeLogging) ? $"<p>{TimeAssembler.AssembleTime()}</p>\n" : "";
            string name = (logNode.Settings.NameLogging) ? $"<h2>{logNode.Settings.Name}</h3>\n" : "";
            string parent = (logNode.Settings.ParentLogging) ? $"<h3 class=\"parent-text\">{logNode.Parent.Settings.Name}</h2>\n" : "";
            string level = (logNode.Settings.LevelLogging) ? $"<h4>Уровень: {logNode.Level}</h4>\n" : "";
            string type = (logNode.Settings.TypeLogging) ? $"<p class=\"type-text\">Тип: {meta[0]}</p>\n" : "";
            string stack = (logNode.Settings.StackLogging) ? $"<p>Стек:\n{meta[1]}<p>\n" : "";
            string message = (logNode.Settings.MessageLogging) ? $"<p class=\"message\">Сообщение: {meta[2]}</p>\n" : "";
            sb.Append(shift); sb.AppendLine("");
            sb.Append(shift); sb.AppendLine($"{time}{name}{parent}{level}{type}");
            sb.Append(shift); sb.AppendLine($"{stack}");
            sb.Append(shift); sb.AppendLine($"{message}");
            sb.Append(shift); sb.AppendLine("<hr>");
            return sb.ToString();
        }

        public static string GetStackPart(int length)
        {
            StackTrace stackTrace = new StackTrace(true);
            StackFrame[] frames = stackTrace.GetFrames();
            if (frames == null || frames.Length < length + 2)
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            // Начинаем с 1, чтобы пропустить текущий метод GetStackPart
            for (int i = 2; i <= length; i++)
            {
                var method = frames[i].GetMethod();
                result.AppendLine($"<p>{method.Name}()</p>");
            }
            return result.ToString().TrimEnd();
        }

    }
}
