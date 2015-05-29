using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PostClient.UI
{
    internal static class PluginManager
    {
        public static string DefaultPluginConfigPath = @"plugins.xml";
        public static List<String> LoadedDllList = new List<string>();
        public static List<KeyValuePair<String, IPlugin>> PluginInstances = new List<KeyValuePair<string, IPlugin>>();

        public static List<String> LoadDllList()
        {
            var result = new List<String>();
            if (!File.Exists(DefaultPluginConfigPath))
                return result;
            try
            {
                using (var fs = new FileStream(DefaultPluginConfigPath, FileMode.Open))
                {
                    var ser = new XmlSerializer(typeof (List<String>));
                    var list = ser.Deserialize(fs) as List<String>;
                    result.AddRange(list);
                }
            }
            catch (SerializationException ex)
            {
            }
            return result;
        }

        public static void SavePluginList()
        {
            using (var fs = new FileStream(DefaultPluginConfigPath, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof (List<String>));
                ser.Serialize(fs, LoadedDllList);
            }
        }

        public static void LoadSavedPlugins(Form form, ListView inboxListView, ListView sentListView,
            ListView pluginListView)
        {
            var dllList = LoadDllList();
            foreach (var path in dllList)
            {
                var types = GetTypesFromAssembly(path);
                foreach (var type in types)
                {
                    var instance = Activator.CreateInstance(type) as IPlugin;
                    PluginInstances.Add(new KeyValuePair<string, IPlugin>(path, instance));
                    instance.DoActions(form, inboxListView, sentListView, pluginListView);
                }
                LoadedDllList.Add(path);
            }
        }

        public static void UnloadAllPlugins()
        {
            foreach (var instance in PluginInstances)
                instance.Value.Dispose();
            PluginInstances.Clear();
            LoadedDllList.Clear();
        }

        private static List<Type> GetTypesFromAssembly(string assemblyPath)
        {
            var assembly = Assembly.LoadFile(assemblyPath);
            var types = assembly.GetTypes();
            var suitableTypes = new List<Type>();
            foreach (var type in types)
                if (!(type.IsAbstract || type.IsInterface || !typeof (IPlugin).IsAssignableFrom(type)))
                    suitableTypes.Add(type);
            return suitableTypes;
        }

        public static void LoadSinglePlugin(string fileName, Form form, ListView inboxListView, ListView sentListView,
            ListView pluginListView)
        {
            if (LoadedDllList.Contains(fileName))
                throw new InvalidOperationException("Sorry, you cannot load plugin twice");
            var types = GetTypesFromAssembly(fileName);
            foreach (var t in types)
            {
                var instance = Activator.CreateInstance(t) as IPlugin;
                PluginInstances.Add(new KeyValuePair<string, IPlugin>(fileName, instance));
                instance.DoActions(form, inboxListView, sentListView, pluginListView);
            }
            LoadedDllList.Add(fileName);
        }

        public static void UnloadSinglePlugin(string filename)
        {
            var path = LoadedDllList.First(p => p.Contains(filename));
            var item = PluginInstances.First(kv => kv.Key == path);
            item.Value.Dispose();
            PluginInstances.Remove(item);
            LoadedDllList.Remove(path);
        }

        public static void UpdatePluginListView(ListView listView)
        {
            listView.Invoke(() =>
            {
                listView.Items.Clear();
                foreach (var path in LoadedDllList)
                    listView.Items.Add(path.Split('\\').Last());
            });
        }
    }
}