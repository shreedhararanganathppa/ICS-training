﻿
/* 1. Develop a console application, which has a class called Calculator. 
 *    This class has functions to add, multiply,subtract and divide 2 nos and 
 *    return the result of addition/subtrcation/multiplication and disvion.
 * 
 *    Using delegates call the methods of Calculator and display the values accordingly  */

using System;

namespace CSharp_Retest
{
    delegate int Airthmatic_Operation (int x,int y);

    class Calculator
    {
        static int num;

        public int Add(int x,int y)
        {
            num = x + y;
            return num;
        }

        public int Multiply(int x,int y)
        {
            num = x * y;
            return num;
        }

        public int Subtract(int x,int y)
        {
            num = x - y;
            return num;
        }

        public int Divide(int x,int y)
        {
            num = x / y;
            return num;
        }

        static void Main()
        {
            //creating class object
            Calculator cal = new Calculator();
           
            //ao1(8, 6);
            //ao2(4, 6);
            //ao3(8, 5);
            //ao4(8, 2);

            //creating objects of the delegate of Airthmatic_Operation

            Airthmatic_Operation ao1 = new Airthmatic_Operation(cal.Add);
            Airthmatic_Operation ao2 = new Airthmatic_Operation(cal.Multiply);
            Airthmatic_Operation ao3 = new Airthmatic_Operation(cal.Subtract);
            Airthmatic_Operation ao4 = new Airthmatic_Operation(cal.Divide);
          
            // Printing the values of all airthmatic Operations of 2 Values

            Console.WriteLine("The Addition value  of the given 2 Numbers is : {0}",ao1(8, 4));
            Console.WriteLine("The multiplied value  of the given 2 Numbers is : {0}", ao2(8, 4));
            Console.WriteLine("The subtracted value of the given 2 Numbers is : {0}", ao3(8, 4));
            Console.WriteLine("The divided value of the given 2 Numbers is : {0}", ao4(8, 4));

            Console.Read();
        }
    }
}
