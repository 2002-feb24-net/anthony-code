using System;

namespace PersonList
{
   class Person
   {
       string firstName;
       string userID;

        //  *** Does not work, gives syntax errors ***
        // private string fName()
        // {
        //     get {return firstName;}
        // }

       public void printUserList()
       {
           System.Console.WriteLine();
       }
       public Person(string firstName, string userID)
       {

       }
   }

}