using System;

namespace Number_Swapper
{
    class Number_Swapper
    {
        /*Write a function to swap two numbers in place (that is, without temporary variables). */
        
        static void Main(string[] args)                 // Start of Program
        { 
            Swap(5, 7);                                 // Calls the Method with test input 5,7 any input will work including binary
        }

        public static void Swap(int x, int y)           // Method used to swap two numbers without additional variables
        {
            x = x ^ y;                                  // This checks if x and y have different values. It results in 1 only if x not = y. If they are not equal it swaps 1 bits to 0 and 0 to 1.
            y = x ^ y;                                  // This is basically the same with y using XOR or explicit OR
            x = x ^ y;                                  // At this point y is equal to origional x 
            Console.WriteLine("X: "+x +" "+"Y: "+y);    // This returns x and y's new values with space between them.
        } 
    }
}
