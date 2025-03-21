using System;

namespace EReliance.Utility
{
    internal static class TimeAssembler
    {
        public static string AssembleTime()
        {
            DateTime dt = DateTime.Now;
            return $"{dt.Hour}:{dt.Minute}:{dt.Second}:{dt.Millisecond}";
        }
    }
}
