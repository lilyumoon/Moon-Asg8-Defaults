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

        public static void setSetting<T>(string settingName, T value)
        {
            if (trySetSetting(settingName, value))
                // only save the setting if it was successfully updated.
                Properties.Settings.Default.Save();
            else
                Debug.WriteLine($"Failed to save setting: {settingName} with value: {value}.");
        }

        private static bool trySetSetting<T>(string settingName, T value)
        {
            bool succeeded = false;

            // check if the setting exists
            if (Properties.Settings.Default[settingName] != null)
            {
                // check if value is not null and is the correct type.
                // if so, assign the value.
                if (value is T)
                {
                    Properties.Settings.Default[settingName] = value;
                    succeeded = true;
                }
            }
            return succeeded;
        }

        public static void resetSetting(string settingName)
        {
            if (tryResetSetting(settingName))
                // only save the setting if it was successfully reset.
                Properties.Settings.Default.Save();
            else
                Debug.WriteLine($"Failed to reset setting: {settingName}.");
        }

        private static bool tryResetSetting(string settingName)
        {
            bool succeeded = false;

            // check if the setting exists
            var settingProperty = Properties.Settings.Default.Properties[settingName];
            if (settingProperty != null)
            {
                // if the setting does exist, retrieve its original value
                //  and assign it to the setting.
                var defaultValue = settingProperty.DefaultValue;
                Properties.Settings.Default[settingName] = defaultValue;

                succeeded = true;
            }
            return succeeded;
        }

    }
}
