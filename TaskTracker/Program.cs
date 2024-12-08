using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TaskTracker.Model;

namespace TaskTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = (AppContext.BaseDirectory + "Tasks.json");
            List<Taskk> tasks;

            if (File.Exists(path))
            {

                string jsonContent = File.ReadAllText(path);
                tasks = JsonSerializer.Deserialize<List<Taskk>>(jsonContent);
                if(tasks == null) 
                    tasks = new List<Taskk>();

            }
            else
            {
                tasks = new List<Taskk>();
            }

            var programLogic = new ProgramLogic(tasks);
            programLogic.MainMenu();

            string updatedJson = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, updatedJson);

        }
    }
}
