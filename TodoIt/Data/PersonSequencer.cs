using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
   public class PersonSequencer
    {
        private static int PersonId;
 public static int nextPersonId()
    { 
          PersonId++;
            return PersonId + PersonId;
        //PersonSequencer Id = new PersonSequencer();
         
        }
        public static void Reset()
        {
            PersonId = 0;
        }

    }
   
}
/*6. Create a new class PersonSequencer in Data folder.
a. In PersonSequencer creates a private static int variable called personId.
b. Add a static method called nextPersonId that increment and return the next
personId value.
c. Add a static method called reset() that sets the personId variable to 0.
d. Unit test PersonSequencer.
e. Commit changes
 
 */