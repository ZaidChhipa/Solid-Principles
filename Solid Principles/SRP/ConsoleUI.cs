using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.SRP
{
    public class ConsoleUI
    {
        private readonly TaskManager taskManager;

        public ConsoleUI(TaskManager taskManager)
        {
            this.taskManager = taskManager;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Display Tasks");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task: ");
                        string newTask = Console.ReadLine();
                        taskManager.AddTask(newTask);
                        break;

                    case "2":
                        Console.Write("Enter task to remove: ");
                        string taskToRemove = Console.ReadLine();
                        taskManager.RemoveTask(taskToRemove);
                        break;

                    case "3":
                        taskManager.DisplayTasks();
                        break;

                    case "4":
                        Console.WriteLine("Exiting application.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
