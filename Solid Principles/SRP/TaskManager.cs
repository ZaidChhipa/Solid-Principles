using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.SRP
{
    public class TaskManager
    {
        private List<string> tasks;

        public TaskManager()
        {
            tasks = new List<string>();
        }

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"- {task}");
            }
        }
    }
}
