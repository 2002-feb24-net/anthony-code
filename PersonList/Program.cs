using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<string> listofUsers = new List<string>();

            var person1 = new Person("Anthony", "101");
            listofUsers.Add(person1.ToString());
            var person2 = new Person("Bobby", "102");
            listofUsers.Add(person2.ToString());
            var person3 = new Person("Charlie", "103");
            listofUsers.Add(person3.ToString());
            var person4 = new Person("David", "104");
            listofUsers.Add(person4.ToString());
            var person5 = new Person("Edward", "105");
            listofUsers.Add(person5.ToString());


            
            // ** Only prints system info, not actual data, does not work**
            // foreach(string x in listofUsers)
            // {
            //     System.Console.WriteLine(x);
            // }
        }
    }
}
