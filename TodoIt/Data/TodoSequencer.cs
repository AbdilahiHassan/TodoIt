using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
       public  class TodoSequencer
    {
        private static int PersonId;
        public static int TodoId()
        {
            PersonId++;
            return PersonId + PersonId;
            //TodoSequencer Id = new TodoSequencer();
            //my be

        }
        public static void Reset()
        {
            PersonId = 0;
        }
    }
}
/*
 Create a new class TodoSequencer in Data folder that have the same behaviour as
PersonSequencer but different method names.
a. Unit test TodoSequencer.
b. Commit changes.
 
 */