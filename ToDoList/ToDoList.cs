using System;
using System.Collections.Generic;
using ToDoList.Models;


namespace ToDoList {
  public class Program
  {
    public static void Main()
    {
      
      Console.WriteLine("Welcome to your To Do List!");
      
      while (true)
      {
        Console.WriteLine("Would you like to Add, Remove, View your tasks? (Add/Remove/View/Exit)");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "add")
        {
          Console.WriteLine("Please type the task you would like to add:");
          string userAddTask = Console.ReadLine();
          new Task(userAddTask);
        }
        else if (userInput.ToLower() == "remove")
        {
          Console.WriteLine("Which task would you like to remove? Please enter the number of the task, bee-atch.");
          foreach (Task task in Task.GetAll())
          {
            Console.WriteLine(task.DisplayTask());
          }
          string userRemoveTask = Console.ReadLine();
          Task.RemoveTask(int.Parse(userRemoveTask));
        }
        else if (userInput.ToLower() == "view")
        {
          foreach (Task task in Task.GetAll())
          {
            Console.WriteLine(task.DisplayTask());
          }
        }
        else if (userInput.ToLower() == "exit")
        {
        
        }
        else
        {
          Console.WriteLine("Invalid selection. Try again.");
        }
      }
    }
  }
}


//   ToDoList  ===  { {desc="", id=0}, {''} , {''} }

//                     0 ,  1    ,  2