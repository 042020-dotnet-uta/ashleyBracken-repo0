using System;

namespace Sweet_and_Salty
{
    class Program 
    {
       
        static void Main(string[] args)
        {
            // instansiate the print results class which inherits the count num class and call the increase num count method
            // and the print out method
            CountNumbers count = new CountNumbers();
            count.IncreaseNumCount();  
        }
    }
}
