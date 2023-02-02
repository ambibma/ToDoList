using System.Collections.Generic;
namespace ToDoList.Models
{
  /// <summary>
  /// Class <c>Task</c> models a task for a to-do list.
  /// </summary>
  public class Task
  {
    public string Description {get; set;}
    
    private static List<Task> _instances = new List<Task> {};

    /// <summary>
    /// This method returns a list of all tasks in the to-do list.
    /// </summary>
    /// <returns>
    /// List of tasks.
    /// </returns>
    public static List<Task> GetAll()
    {
      return _instances;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Task"/> class.
    /// </summary>
    /// <param name="description">The description of the task</param>
    public Task(string description)
    {
      Description = description;
      _instances.Add(this);
    }
    
    /// <summary>
    /// This method clears the list of all tasks in the to-do list.
    /// </summary>
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}