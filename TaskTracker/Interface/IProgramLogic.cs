using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Interface
{
    public interface IProgramLogic
    {
        public void MainMenu();
        public void AddTask();
        public void RemoveTask();
        public void GetAllTasks();
        public void GetTasksByStatus();
        public void UpdateStatus();
    }
}
