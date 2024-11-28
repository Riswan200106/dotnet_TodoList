using System;
using System.Collections.Generic;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Todo List Program.");
            Console.WriteLine("*******************************************");
            List<string> tasklist = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("\nWhat would you like to do:");
                Console.WriteLine("1. Add a task to the todo list");
                Console.WriteLine("2. Remove a task from the todo list");
                Console.WriteLine("3. View the list");
                Console.WriteLine("e. Exit the program");
                Console.WriteLine("*******************************************");

                option = Console.ReadLine();

                if (option == "1") // Add task
                {
                    Console.Write("Please enter your task: ");
                    string task = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(task))
                    {
                        tasklist.Add(task);
                        Console.WriteLine($"Task '{task}' has been added to the list.");
                    }
                    else
                    {
                        Console.WriteLine("Task cannot be empty. Please try again.");
                    }
                }
                else if (option == "2") // Remove task
                {
                    if (tasklist.Count == 0)
                    {
                        Console.WriteLine("The task list is empty. Nothing to remove.");
                        continue;
                    }

                    Console.WriteLine("Current tasks in the list:");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine($"{i}. {tasklist[i]}");
                    }

                    Console.Write("Please enter the number of the task to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 0 && taskNumber < tasklist.Count)
                    {
                        Console.WriteLine($"Task '{tasklist[taskNumber]}' has been removed.");
                        tasklist.RemoveAt(taskNumber);
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number. Please try again.");
                    }
                }
                else if (option == "3") // View tasks
                {
                    if (tasklist.Count == 0)
                    {
                        Console.WriteLine("The task list is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Current tasks in the list:");
                        Console.WriteLine("*******************************************");
                        for (int i = 0; i < tasklist.Count; i++)
                        {
                            Console.WriteLine($"{i}. {tasklist[i]}");
                        }
                    }
                }
                else if (option == "e") // Exit
                {
                    Console.WriteLine("Exiting the Todo List Program.");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }

            Console.WriteLine("Thank you for using the Todo List Program!");
        }
    }
}
