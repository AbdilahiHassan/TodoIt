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
            int person;
            int persinId;
            //Act
            People array = new People();
            person = 0;
            persinId = 0;
            //Asser
            Assert.Equal(0, persinId);

        }
    }
}
