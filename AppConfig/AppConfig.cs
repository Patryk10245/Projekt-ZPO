using Newtonsoft.Json;
using Projekt_ZPO;
using System;
public class AppConfig
{
    private static AppConfig _instance;

    public static AppConfig Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new AppConfig();
            }
            return _instance;
        }
    }
    public AppConfig()
    {
        if (!File.Exists(configPath))
        {
            SaveConfig();
        }
    }
    [JsonIgnore]
    public string configPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\AppConfig\AppConfig.json");

    [JsonIgnore]
    public string gameCollectionPath { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\GameCollection.json");

    public string configFile { get; set; } = "AppConfig.json";
    public string gameCollectionFile { get; set; } = "GameCollection.json";
    public string libraryName { get; set; } = "My Game Collection";
    public string appVersion { get; set; } = "1.0.0";
    public string appAuthor { get; set; } = "Serafino";
    public string appDescription { get; set; } = "A simple game collection manager application.";
    public string appLicense { get; set; } = "MIT License";



    public void SaveConfig()
    {
        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(configPath, json);

    }

    public AppConfig LoadConfig()
    {
        if (File.Exists(configPath))
        {
            string json = File.ReadAllText(configPath);
            
            return JsonConvert.DeserializeObject<AppConfig>(json);
        }
        else
        {
            var config = new AppConfig();
            config.SaveConfig();
            
            return config;
        }
    }
}