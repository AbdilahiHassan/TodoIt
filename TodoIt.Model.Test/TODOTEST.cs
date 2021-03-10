using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TodoIt.Model.Test
{
    public class TODOTEST
    {
            [Fact]
            public void Dotest()
        {

            //Arrange 
            // int ToDoId
            string descrip = "spelTest";
            bool done = true;
            // int ToDoId
            TODO TestTODO = new TODO(done, descrip);

            //Asser
            Assert.Equal("spelTest", TestTODO.descrip);
            Assert.Equal(true, TestTODO.Done);
        }
        //Passt this test
    }
}