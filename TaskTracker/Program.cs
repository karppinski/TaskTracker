using System.Text.Json;
using TaskTracker.Model;
namespace TaskTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taskk> tasks = new List<Taskk>();

            string path = (AppContext.BaseDirectory + "Tasks.json");
            var fileExisist = File.Exists(path);
            if (fileExisist)
            {
                byte[] content = File.ReadAllBytes(path);
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

            Console.WriteLine("Welcome in task tacker, what You want to do ? ");

            
 

            Console.WriteLine("Hello, World!");
        }
    }
}
