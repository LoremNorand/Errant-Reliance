namespace EReliance.Preset
{
    public static class LogNodeBuilder
    {
        public static Core.LogNode BuildChild(Core.LogNode parent)
        {
            Core.LogNode child = new Core.LogNode();
            child.Settings.AssignPreset(parent.Settings.PresetName);
            child.Parent = parent;
            return child;
        }
    }
}
