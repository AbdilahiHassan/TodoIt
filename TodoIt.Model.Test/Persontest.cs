using System;
using Xunit;

namespace TodoIt.Model.Test
{
    public class Persontest
    {
        [Fact]
        public void PTest()
        {

            //Arrange

           //int personId = 100;
            string firstName = "Abdilahi";
            string lastName = "Hassan";
            // Act
           
            Person P = new Person(firstName, lastName);
            P.firstName = "Abdilahi";
            P.lastName = "Hassan";
            //Assert
            // Assert.Equal(100, P.personId);
            Assert.Equal(firstName, P.firstName);
            Assert.Equal(lastName, P.lastName);
        }
    }
}
