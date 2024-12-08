using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TaskTracker.Interface;
using TaskTracker.Model;
using Xunit.Sdk;

namespace TaskTracker
{
    public class ProgramLogic : IProgramLogic
    {
        private readonly List<Taskk> _tasks;
        private readonly TaskLogic _taskLogic;

        public ProgramLogic(List<Taskk> tasks)
        {
            _tasks = tasks;
            _taskLogic = new TaskLogic(_tasks);  
        }


        public void MainMenu()
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Welcome in task Tracker, what You want to do?");
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. List all Tasks");
                Console.WriteLine("3. List tasks with specific status");
                Console.WriteLine("4. Update task");
                Console.WriteLine("5. Remove task");
                Console.WriteLine("6. Quit program and save changes");
                Console.WriteLine();
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        GetAllTasks();
                        break;
                    case 3:
                        GetTasksByStatus();
                        break;
                    case 4:
                        UpdateStatus();
                        break;
                    case 5:
                        RemoveTask();
                        break;
                    case 6:
                        runProgram = false;
                        break;
                }
                        
            }

        }

        public void AddTask()
        {
            Console.WriteLine("Insert task description and press enter");
            var taskDescription  = Console.ReadLine().ToString();
            _taskLogic.AddTask(taskDescription);
            Console.WriteLine("Task created! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void RemoveTask()
        {
            Console.WriteLine("Insert task Id and press enter.");
            int userInput = int.Parse(Console.ReadLine());
            _taskLogic.DeleteTask(userInput);
            Console.WriteLine("Task deleted! Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void GetAllTasks()
        {
            Console.WriteLine("Here is list of all tasks: ");
            _taskLogic.GetAllTasks();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public void GetTasksByStatus()
        {
            Console.WriteLine(""
        }

        public void UpdateStatus()
        {
            throw new NotImplementedException();
        }
    }
}
