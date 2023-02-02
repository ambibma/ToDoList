using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoList.Models;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class TaskTests : IDisposable
  {
    public void Dispose()
    {
      Task.ClearAll();
    }
  
    [TestMethod]
    public void TaskConstructor_CreatesInstanceOfTask_Task()
    {
      Task newTask = new Task("test");
      Assert.AreEqual(typeof(Task), newTask.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Task newTask = new Task(description);
      //Act
      string result = newTask.Description;
      //Assert
      Assert.AreEqual(description, result);

    } 
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Walk the dog.";
      Task newTask = new Task(description);
      
      string updatedDescription = "Do the dishes";
      newTask.Description = updatedDescription;
      string result = newTask.Description;

      Assert.AreEqual(updatedDescription, result);

    }

    [TestMethod] 
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<Task> newList = new List<Task> { };

      List<Task> result = Task.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
