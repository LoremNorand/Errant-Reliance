namespace EReliance.Preset
{
    public partial class LogNodeSettingsPresets
    {
        // Инициализатор стандартных шаблонов
        private void InitializeDefaultPresets()
        {
            _logNodeSettings.Add("Короткий",
                new Entity.LogNodeSettings()
                {
                    StackLogging = false,
                    ParentLogging = false,
                    TypeLogging = false,
                    TimeLogging = false,
                    LevelLogging = false
                });
            _logNodeSettings.Add("Стандартный",
                new Entity.LogNodeSettings()
                {
                    ParentLogging = false,
                    StackLogging = false,
                    LevelLogging = false
                });
            _logNodeSettings.Add("Полный",
                new Entity.LogNodeSettings()
                {

                });
        }
    }
}
