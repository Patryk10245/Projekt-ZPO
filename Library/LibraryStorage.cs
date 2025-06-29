﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_ZPO.LibraryManager;
using Projekt_ZPO.Interfaces;

namespace Projekt_ZPO.Storage
{
    public class LibraryStorage : ILibraryStorage
    {
        private string gameCollectionPath = AppConfig.Instance.gameCollectionPath;
        public void SaveLibrary(Library library)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            try
            {
                string json = JsonConvert.SerializeObject(library, settings);
                File.WriteAllText(gameCollectionPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving collection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public Library LoadLibrary()
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };
            if (File.Exists(gameCollectionPath))
            {
                string json = File.ReadAllText(gameCollectionPath);
                return JsonConvert.DeserializeObject<Library>(json, settings);
            }
            else
            {
                return new Library();
            }
        }

    }
}
