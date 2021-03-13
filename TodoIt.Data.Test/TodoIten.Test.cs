using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace TodoIt.Data.Test
{
    public class TodoIt
    {
        [Fact]
        public void ToditemTets()
        {
            //Arrange 
            int todo;
            int persinId;
            //Act
            TodoItems array = new TodoItems();
            todo = 0;
            persinId = 0;
            //Asser
            Assert.Equal(0, persinId);

        }
    }
}
