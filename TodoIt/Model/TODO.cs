using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
   public class TODO
    {
        int ToDoId;
        string Description;
        bool done = true;

        public int ToDod
        {
            get
            {
                return ToDoId;

            }
        }
        public string descrip
        {
            get
            { return Description; }
            private set { Description = value; }
        }

        public bool Done
        {
            get
            { return done; }
            private set
            { done = value; }
        }

        public TODO(bool done, string Description)
        {
            this.done = done;
            this.Description = Description;
        }


    }
}
