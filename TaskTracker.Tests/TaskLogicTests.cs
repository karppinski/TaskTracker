using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Interface;
using TaskTracker.Model;

namespace TaskTracker.Tests
{
    public class TaskLogicTests
    {
        [Fact]
        public void TaskLogic_AddTask_IfTaskHasDescriptionReturns1()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            
            var result = taskLogic.AddTask("New Task");

            Assert.Equal(1, result);
        } 

        [Fact]
        public void TaskLogic_AddTask_IfTaskHasNoDescriptionReturns0()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            
            var result = taskLogic.AddTask(string.Empty);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaskLogic_DeleteTask_IfCorrespondingIdTaskNotFoundReturns0()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);

            var result = taskLogic.DeleteTask(5);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaskLogic_DeleteTask_IfTaskWasDeletedReturns1()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            Taskk task = new Taskk()
            {
                Id = 1,
                Description = "TestDescription",
                Status = Status.toDo,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            tasks.Add(task);

            var result = taskLogic.DeleteTask(task.Id);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TaskLogic_GetAllTasks_WithEmptyListReturns0()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);

            var result = taskLogic.GetAllTasks();

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaskLogic_GetAllTasks_WithTasksReturns1()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            Taskk task = new Taskk()
            {
                Id =  1,
                Description = "TestDescription",
                Status = Status.toDo,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            tasks.Add(task);

            var result = taskLogic.GetAllTasks();

            Assert.Equal(1, result);
        }

        [Fact]
        public void TaskLogic_GetTasksByStatus_IfNotFoundReturns0()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);

            var result = taskLogic.GetTasksByStatus(Status.inProgress);

            Assert.Equal(0, result);
        }
        [Fact]
        public void TaskLogic_GetTasksByStatus_WithTasksReturns1()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            Taskk task = new Taskk()
            {
                Id = 1,
                Description = "TestDescription",
                Status = Status.toDo,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            tasks.Add(task);

            var result = taskLogic.GetTasksByStatus(Status.toDo);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TaskLogic_UpdateStatus_IfTaskNotFoundReturns0()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);

            var result = taskLogic.UpdateStatus(1, Status.toDo);

            Assert.Equal(0, result);
        }

        [Fact]
        public void TaskLogic_UpdateStatus_IfUpdatedReturns1()
        {
            var tasks = new List<Taskk>();
            TaskLogic taskLogic = new TaskLogic(tasks);
            Taskk task = new Taskk()
            {
                Id = 1,
                Description = "TestDescription",
                Status = Status.toDo,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            tasks.Add(task);

            var result = taskLogic.UpdateStatus(1, Status.inProgress);

            Assert.Equal(1, result);
        }
    }
}
