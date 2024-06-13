using Xunit;
using ContactManager;

namespace ContactManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddContact_ValidContact_AddsSuccessfully()
        {
            //Arrange
            Program.AddContact("Alice");
            //Act
            var contacts = Program.ViewAllContacts();
            //Assert
            Assert.Contains("Alice", contacts);
        }

        [Fact]
        public void AddContact_ExistingContact_ThrowsException()
        {
            //Arrange
            Program.AddContact("Bob");
            //Act
            var exception = Assert.Throws<ArgumentException>(() => Program.AddContact("Bob"));
            //Assert
            Assert.Equal("Contact already exists.", exception.Message);
        }

        [Fact]
        public void RemoveContact_ExistingContact_RemovesSuccessfully()
        {
            //Arrange
            Program.AddContact("Charlie");
            //Act
            var contacts = Program.RemoveContact("Charlie");
            //Assert
            Assert.DoesNotContain("Charlie", contacts);
        }

        [Fact]
        public void ViewAllContacts_ReturnsAllContacts()
        {
            Program.AddContact("Dave");
            //Act
            var contacts = Program.ViewAllContacts();
            //Assert
            Assert.Contains("Dave", contacts);
        }
    }
}