// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Microsoft.Extensions.Configuration;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Google.Ads.GoogleAds.Config {

  /// <summary>
  /// This class reads the configuration keys from App.config.
  /// </summary>
  public class ConfigBase : ICloneable, INotifyPropertyChanged {

    /// <summary>
    /// The default constructor.
    /// </summary>
    protected ConfigBase() {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigBase"/> class.
    /// </summary>
    /// <param name="configurationRoot">The configuration root.</param>
    protected ConfigBase(IConfigurationRoot configurationRoot) : base() {
      ReadSettings(LoadConfigRoot(configurationRoot));
    }

    /// <summary>
    /// Attempts to load the configuration from a configuration root.
    /// </summary>
    /// <param name="configurationRoot">The configuration root.</param>
    /// The configuration, or <code>null</code> if none was found.
    protected Dictionary<string, string> LoadConfigRoot(IConfigurationRoot configurationRoot) {
      return configurationRoot.AsEnumerable().ToDictionary(
          setting => setting.Key.ToString(),
          setting => setting.Value.ToString());
    }

    /// <summary>
    /// Attempts to load the configuration section with the given name.
    /// </summary>
    /// <param name="sectionName">The name of the configuration section to load.</param>
    /// <returns>
    /// The request configuration section, or <code>null</code> if none was found.
    /// </returns>
    protected Dictionary<string, string> LoadConfigSection(string sectionName) {
      IConfigurationRoot configurationRoot =
          MemoryConfigurationBuilderExtensions.AddInMemoryCollection(
              new ConfigurationBuilder(), LoadAppConfig(sectionName)).Build();
      return LoadConfigRoot(configurationRoot);
    }

    /// <summary>
    /// Loads the application configuration XML.
    /// </summary>
    /// <param name="sectionName">Name of the section.</param>
    /// <returns>The App.config loaded as a list of KeyValuePair.</returns>
    private IEnumerable<KeyValuePair<string, string>> LoadAppConfig(string sectionName) {
      Hashtable config = (Hashtable) ConfigurationManager.GetSection(sectionName);

      Dictionary<string, string> retval = new Dictionary<string, string>();
      if (config != null) {
        foreach (string key in config.Keys) {
          retval.Add(key, (string) config[key]);
        }
      }

      return retval;
    }

    /// <summary>
    /// Read all settings from App.config.
    /// </summary>
    /// <param name="settings">The parsed app.config settings.</param>
    protected virtual void ReadSettings(Dictionary<string, string> settings) {
    }

    /// <summary>
    /// Reads a setting from a given dictionary.
    /// </summary>
    /// <param name="settings">The settings collection from which the keys
    /// are to be read.</param>
    /// <param name="settingField">The field that holds the setting value.</param>
    protected void ReadSetting(Dictionary<string, string> settings,
        ConfigSetting settingField) {
      if (settings != null && settings.ContainsKey(settingField.Name)) {
        settingField.TryParse(settings[settingField.Name]);
      }
    }

    /// <summary>
    /// Sets the specified property and notify any listeners.
    /// </summary>
    /// <typeparam name="SettingType">Type of the property.</typeparam>
    /// <param name="field">The field that store property value.</param>
    /// <param name="newValue">The new value to be set.</param>
    /// <param name="propertyName">Name of the property.</param>
    protected void SetPropertyAndNotify<SettingType>(ConfigSetting<SettingType> field,
        SettingType newValue, [CallerMemberName] String propertyName = "") {
      if (!EqualityComparer<SettingType>.Default.Equals(field.Value, newValue)) {
        field.Value = newValue;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    /// <summary>
    /// Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Creates a new object that is a copy of the current instance.
    /// </summary>
    /// <returns>
    /// A new object that is a copy of this instance.
    /// </returns>
    public virtual object Clone() {
      return MemberwiseClone();
    }
  }
}
