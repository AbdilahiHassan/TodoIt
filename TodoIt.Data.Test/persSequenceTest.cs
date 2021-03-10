using System;
using Xunit;

namespace TodoIt.Data.Test
{
    public class PersonseqTest
    {
        [Fact]
        public void personSqTest()
        {
            //Arrange 
            int PersonId = 0;

            PersonSequencer Id = new PersonSequencer();
            PersonId = 0;
            //Asser
            Assert.NotEqual(1, PersonId);

        }
    }
}
