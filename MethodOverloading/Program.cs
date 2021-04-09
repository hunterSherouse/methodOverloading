using System;
using System.Collections.Generic;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        //methods:
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            if(z == true)
            {
                var result = x + y;
                if (result == 1)
                { 
                    return ($"{result} dollar."); 
                }
                else
                {
                    return ($"{result} dollars.");
                }

            }

            else
            {
                var result = x + y;
                return ($"{result}");
            }

        }

    }




    
}


