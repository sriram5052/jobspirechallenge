using System;

namespace jobspire
{
    class Program
    {
        private static readonly Random rdm = new Random();    //create a object for random class    
        static void Main(string[] args)
        {

           Console.WriteLine(getrandom(Console.ReadLine().ToString())); /*get the input from  
                                                                          console and pass it to 
                                                                          the method getrandom and 
                                                                          print's the result in console */
            Console.ReadKey(); // to wait for a key from user
        }

        public static string  getrandom(string name)//getrandom method accepts a string input
        {
           
                return name +" "+rdm.Next(6, 15);/* appends the random 
                                                    number generated between 6,15 
                                                    to the input and returns as a result*/
           
        }      
       
    }
}
