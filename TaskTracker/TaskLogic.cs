using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Interface;
using TaskTracker.Model;

namespace TaskTracker
{
    public class TaskLogic : ITaskLogic
    {
        private readonly List<Taskk> _tasks;

        public TaskLogic(List<Taskk> tasks)
        {
            _tasks = tasks;
        }

        public int AddTask(string taskDescription)
        {
            int taskAmount = _tasks.Count;

            Taskk task = new Taskk()
            {
                Id = taskAmount + 1,
                Description = taskDescription,
                Status = Status.toDo,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _tasks.Add(task);
            Console.WriteLine("Task created!");
            return 1;
        }

        public int DeleteTask(int taskId)
        {
            Taskk taskToDelete = _tasks.FirstOrDefault(x => x.Id == taskId);
            if (taskToDelete == null)
            {
                Console.WriteLine($"Task with id {taskId} not found! ");
                return 0;
            }
            _tasks.Remove(taskToDelete);
            Console.WriteLine("Task deleted");
            return 1;
        }

        public int GetAllTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("There are not tasks on the list!");
                return 0;
            }
            foreach (Taskk t in _tasks)
            {
                Console.WriteLine($"TaskId = {t.Id}");
                Console.WriteLine($"Task Description = {t.Description}");
                Console.WriteLine($"Task Status = {t.Status}");
                Console.WriteLine($"Created at = {t.CreatedAt}");
                Console.WriteLine($"Updated at = {t.UpdatedAt}");
            }
            return 1;
        }

        public int UpdateStatus(int taskId, Status status)
        {
            Taskk taskToUpdate = _tasks.FirstOrDefault(x => x.Id == taskId);
            if (taskToUpdate == null)
            {
                Console.WriteLine($"Task with id {taskId} not found!");
            }
            taskToUpdate.Status = status;
            taskToUpdate.UpdatedAt = DateTime.Now;
            Console.WriteLine("Task Updated!");
            return 1;
        }
    }
}
