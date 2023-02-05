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
        foreach (Task task in Task.GetAll())
        // {
        //   Console.WriteLine(task.DisplayTask());
        // }
        // List<Task> Tasks = new List<Task>() {};
        Console.WriteLine("Would you like to Add, Remove, or View your tasks? (Add/Remove/View)");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "add")
        {
          Console.WriteLine("Please type the task you would like to add:");
          string userAddTask = Console.ReadLine();
          new Task(userAddTask);
        }
        if (userInput.ToLower() == "remove")
        {
          
          Console.WriteLine("Which task would you like to remove? Please enter the number of the task, bee-atch.");
          string userRemoveTask = Console.ReadLine();
          // Task.RemoveTask(int.Parse(userRemoveTask));
        }
      }
    }
  }
}


//   ToDoList  ===  { {desc="", id=0}, {''} , {''} }

//                     0 ,  1    ,  2