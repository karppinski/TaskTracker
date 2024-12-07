using System.Text.Json;
using TaskTracker.Model;
namespace TaskTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] content;
            List<Taskk> tasks = new List<Taskk>();

            string path = (AppContext.BaseDirectory + "Tasks.json");
            var fileExisist = File.Exists(path);
            if (fileExisist)
            {
                content = File.ReadAllBytes(path);
                if (content.Length == 4 )
                {
                    Console.WriteLine("List of tasks is empty");
                }
                else
                {
                    tasks = JsonSerializer.Deserialize<List<Taskk>>(content);
                }
            }
            else 
            { 
            File.WriteAllText(path, "[]");
            }
            
            TaskLogic taskLogic = new TaskLogic(tasks);
            
 

            Console.WriteLine("Hello, World!");
        }
    }
}
