using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Asg8_Defaults
{
    public static class SettingsManager
    {

        public static void setSetting<T>(string name, T value)
        {
            if (trySetSetting(name, value))
                Properties.Settings.Default.Save();
            else
                Debug.WriteLine($"Failed to save setting: {name} with value: {value}.");
        }

        private static bool trySetSetting<T>(string name, T value)
        {
            bool succeeded = false;

            // ensure the setting exists
            if (Properties.Settings.Default[name] != null)
            {
                // ensure value is not null and is the correct type before assigning the value
                if (value is T)
                {
                    Properties.Settings.Default[name] = value;
                    succeeded = true;
                }
            }
            return succeeded;
        }

        public static void resetSetting(string name)
        {
            if (tryResetSetting(name))
                Properties.Settings.Default.Save();
            else
                Debug.WriteLine($"Failed to reset setting: {name}.");
        }

        private static bool tryResetSetting(string name)
        {
            bool succeeded = false;

            // ensure setting exists
            var settingProperty = Properties.Settings.Default.Properties[name];
            if (settingProperty != null)
            {
                var defaultValue = settingProperty.DefaultValue;
                Properties.Settings.Default[name] = defaultValue;

                succeeded = true;
            }
            return succeeded;
        }

    }
}
