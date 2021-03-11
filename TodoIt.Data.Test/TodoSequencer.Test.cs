using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace TodoIt.Data.Test
{
    public class TodoSequencer
    {
        [Fact]
        public void TodoSqTest()
        {
            //Arrange 
            int PersonId = 0;

            TodoSequencer Id = new TodoSequencer();
            PersonId = 0;
            //Asser
            Assert.NotEqual(1, PersonId);

        }
    }
}
