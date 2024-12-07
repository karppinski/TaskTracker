using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Model;

namespace TaskTracker.Interface
{
     public interface ITaskLogic
    {
        int GetAllTasks();
        int AddTask(string taskDescription);
        int UpdateStatus(int taskId, Status status);
        int DeleteTask(int taskId);

    }
}
