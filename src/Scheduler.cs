// Task Scheduler
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskSchedulerTool
{
    public class Scheduler
    {
        private readonly List<Task> _tasks;

        public Scheduler()
        {
            _tasks = new List<Task>();
        }

        // Add a new task to the scheduler
        public void AddTask(string taskName, TimeSpan delay)
        {
            if (string.IsNullOrWhiteSpace(taskName))
                throw new ArgumentException("Task name cannot be empty.", nameof(taskName));
            if (delay < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameof(delay), "Delay cannot be negative.");
            
            var task = new Task(() => ExecuteTask(taskName));
            _tasks.Add(task);
            Task.Delay(delay).ContinueWith(t => task.Start());
        }

        // Execute the given task name
        private void ExecuteTask(string taskName)
        {
            Console.WriteLine($"Executing task: {taskName}");
            // Simulate work being done by sleeping for a second.
            Task.Delay(1000).Wait();
            Console.WriteLine($"Completed task: {taskName}");
        }
    }
}
