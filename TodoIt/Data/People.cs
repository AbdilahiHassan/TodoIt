using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;
namespace TodoIt.Data
{
    public class People
    {

        private static Person[] personList = new Person[]{

        };
        int sizeOfArray = personList.Length;
        public static int Size()
        {
            return personList.Length;
        
        }
     
        public  Person[] FindAll ()
        {
            return personList;
        }
        public Person FindById(int personId)
        {

            for (int i = 0; i <personList.Length; i++)
            {
                if(personList[i].personId == personId)
                {
                    return personList[i];
                }

            }
            return null;
        }
        public Person [] CreatePerson(Person[] person)

        {
            People array = new People();
            array.CreatePerson(person);
           //length
          Array.Resize(ref personList, + 1);
            return person;
         // return sizeOfArray;
           
        }
        public  void Clea()
        {
            Array.Clear(personList, 0, personList.Length);
        }

    }


}
