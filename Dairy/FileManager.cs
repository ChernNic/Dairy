using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using Dairy.Models;
using Newtonsoft.Json;

namespace Dairy
{
    static class FileManager
    {
        static public void SaveToFile(BindingList<NoteModel> list, string path)
        {
            if (!File.Exists(Environment.SystemDirectory + path))
            {
                FileStream fileStream = File.Create(Environment.SystemDirectory + "/" + path);
                fileStream.Dispose();
            }

            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(Environment.SystemDirectory + "/" + path, json);
        }
      
        static public BindingList<NoteModel> ReadFromFile(string path)
        {
            BindingList<NoteModel> result;
            if (!File.Exists(Environment.SystemDirectory + "/" + path))
            {
                FileStream fileStream = File.Create(Environment.SystemDirectory + "/" + path);
                fileStream.Dispose();
            }

            string resultInfo = File.ReadAllText(Environment.SystemDirectory + "/" + path);
            result = JsonConvert.DeserializeObject<BindingList<NoteModel>>(resultInfo);

            return result;
        }
    }
}
