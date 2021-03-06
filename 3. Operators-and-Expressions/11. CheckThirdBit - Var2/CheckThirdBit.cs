﻿using System;

class CheckThirdBit
{
    static void Main()
    {
        //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 
        Console.Title = "ConsoleApp - CheckThirdBit";
        Console.WriteLine("Please enter a number: ");
        int inputNum = int.Parse(Console.ReadLine());
        string stringForCheck = Convert.ToString(inputNum, 2);
        stringForCheck = new string('0', (32-stringForCheck.Length)) + stringForCheck;
        if ((stringForCheck[28]) == '1')
        {
            Console.WriteLine("The third bit of the number {0} is 1!", stringForCheck);
        }
        else
        {
            Console.WriteLine("The third bit of the number {0} is 0!", stringForCheck);
        }
        Console.ReadLine();
    }
}
