/*
//Class finds sum and production in range of numbers 1...10

using System;

class SumProd
{
    static void Main()
    {
        int sum, prod, count;

        sum = 0;
        prod = 1;

        for (count = 1; count <= 10; count++)
        {
            sum = sum + count;
            prod = prod * count;
        }


        Console.WriteLine("Sum of numbers is " + sum);
        Console.WriteLine("Production of numbers is " + prod);
    } 
}
*/