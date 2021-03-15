using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class TodoItems
    {

        private static TODO[] todoList = new TODO[0];

        
        int sizeOfArray = todoList.Length;
        public static int Size()
        {
            return todoList.Length;
         
        }

        public TODO []FindAll()
        {
            
            return todoList;
        }
        public TODO FindById(int TodoId)
        {
            for (int i = 0; i < todoList.Length; i++)
            {
                if(todoList[i].ToDoId == TodoId)
                {
                    return todoList[i];
                }
            }
            return null;
        }
        public int CreatenewTodo(string Description)

        {
            TodoItems array = new TodoItems();
            array.CreatenewTodo(Description);
         
            Array.Resize(ref todoList, 10);
            return sizeOfArray;

        }
        public void Clea()
        {
            Array.Clear(todoList, 0, todoList.Length);
        }

        public  bool[] FindByDoneStatus(bool[] donestatus)

        {
            TODO[] personalTodoLis = new TODO[0];
            for (int i = 0; i < todoList.Length; i++)
            {
                if (todoList[i].done == true)
                {
                    Array.Resize(ref personalTodoLis, personalTodoLis.Length + 1);
                    Array.IndexOf(personalTodoLis, donestatus);
                   // return donestatus;
                }

            }
            return donestatus;
      }
        public TODO[] FindByAssignee(int personId)

        {
            //innehåller bara dina personlist
            TODO[] personalTodoLis = new TODO[0];
            

            for (int i = 0; i <todoList.Length; i++)
            {
                if (todoList[i].Assignee.personId == personId )
                {
                    Array.Resize(ref personalTodoLis, personalTodoLis.Length + 1);

                    Array.IndexOf( todoList, personalTodoLis);
                 //gör plats i personal to list i en till 
                 //sätta in todo i persolantodolist
                }
                
            }
            return personalTodoLis;
        }
        public TODO[] FindByAssignee(Person assignee)
        {
            TODO[] personAssignee = new TODO[0];
            for (int i = 0; i <todoList.Length; i++)
            {
                if (todoList[i].Assignee == assignee)
                {
                    Array.Resize(ref personAssignee, todoList.Length + 1);

                    Array.IndexOf(todoList, personAssignee);

                }
            }
            return personAssignee;
        }
        public TODO[] FindUnassignedTodoItems()
        {
            TODO[] UnAssignee = new TODO[0];
            for (int i = 0; i <todoList.Length; i++)
            {
             if(todoList[i].Assignee == null)
                {
                Array.IndexOf(todoList, UnAssignee);
                    // return todoList;
                }
            }
            return UnAssignee;
        }
        public void Remove(TODO value)
        {
            int index = Array.IndexOf( todoList, todoList.Length);

            Array.Clear(todoList, 0, index);

        }
    }
}
