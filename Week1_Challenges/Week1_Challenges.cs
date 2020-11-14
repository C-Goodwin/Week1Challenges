using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1_Challenges
{
    [TestClass]
    public class Week1_Challenges
    {
        [TestMethod]
        public void TestMethod1()
        {//Challenge One
            string firstName = "Cassandra";
            string lastName = "Goodwin";
            int age = 27;
        //Challenge 2
            string favBooks1 = "It by Stephen King";
            string favBooks2 = "Jurassic Park by Michael Crichton";
            string favBooks3 = "The Hobbit by J.R.R. Tolkien";
            string favBooks4 = "Alice in Wonderland by Lewis Carrol";
            string[] favoriteBooks = { favBooks1, favBooks2, favBooks3, favBooks4 };
         //Challenge 3
            List<DateTime> dueDates = new List<DateTime>();
            dueDates.Add(new DateTime.Now);
            dueDates.Add(new DateTime(2020, 11, 12));
         //Challenge 4
            int numTwo = 7;
            int sum = age + numTwo;
            Console.WriteLine(sum);
            int diff = age - numTwo;
            Console.WriteLine(diff);
            int prod = age * numTwo;
            Console.WriteLine(prod);
            int quot = age / numTwo;
            Console.WriteLine(quot);
            int remainder = age % numTwo;
            Console.WriteLine(remainder);
         //Challenge 5
            int hours = 7;
           
            if (hours >= 10)
            { Console.WriteLine("Wow that's a lot of sleep!"); }

            else if(hours >= 8)
            { Console.WriteLine("You should be pretty rested."); }

            else if (hours > 4)
            { Console.WriteLine("Bummer!"); }

            else
            { Console.WriteLine("Oh man, get some sleep!"); }

         //Challenge 6 

            string howsItBeen;
            switch(howsItBeen)
            {
                case: "Great"
                        { Console.WriteLine("That's Fantastic!"); }
                case: "Good"
                        { Console.WriteLine("That's good to hear."); }
                case: "Okay"
                        { Console.WriteLine("That could be better, but at least it's not bad."); }
                case: "Bad"
                        { Console.WriteLine("Well that's no good."); }
                case ":("
                    { Console.WriteLine("Oh no!"); }
            }




        }
    }
}
