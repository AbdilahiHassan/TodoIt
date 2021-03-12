using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoItems
    {

        private static int[] person = new int[]{

        };
        int sizeOfArray = person.Length;
        public static int Size()
        {
            return person.Length;
            //sizeof.

        }

        public int FindAll(int[] person)
        {
            return sizeOfArray;
        }
        public int FindById(int[] personId)
        {
            person = personId;
            return sizeOfArray;
        }
        public int CreatePerson(int[] persinId)

        {
            People array = new People();
            array.CreatePerson(persinId);
            // person[0] = 1;
            //person[1] = 1;
            Array.Resize(ref person, 10);

            return sizeOfArray;

        }
        public void Clea()
        {
            Array.Clear(person, 0, person.Length);
        }
    }
}
//TodoItems should have the same
//functionality as the People class.