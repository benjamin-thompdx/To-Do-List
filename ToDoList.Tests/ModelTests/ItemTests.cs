using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

[TestMethod]
public void GetDescription_ReturnsDescription_String()
{
  //Arrange
  string description = "Walk the dog.";
  Item newItem = new Item(description);

  //Act
  string updatedDescription = "Do the dishes";
  newItem.Description = updatedDescription;
  string result = newItem.Description;

  //Assert
  Assert.AreEqual(updatedDescription, result);
}

  }
}