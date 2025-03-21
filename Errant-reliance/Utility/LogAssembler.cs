using System;
using System.Text;

namespace EReliance.Utility
{
    internal static class LogAssembler
    {
        public static string AssembleMessage(Core.LogNode logNode, string meta)
        {
            StringBuilder sb = new StringBuilder();
            string time = (logNode.Settings.TimeLogging) ? TimeAssembler.AssembleTime() : null;
            return sb.ToString();
        }
    }
}
