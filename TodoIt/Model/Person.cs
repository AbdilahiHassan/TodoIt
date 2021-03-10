using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public  class Person
    {
        public int personId;
        public string firstName;
        public string lastName;


        public int PersonId
        {
            get
            {
                return personId;
            }

        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
            }

        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            personId = 100;
        }
        public Person()
        {
            personId = 100;
        }



        // personclass
    }

}