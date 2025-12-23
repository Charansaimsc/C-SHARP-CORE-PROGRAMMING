/*a. Write a Method to Check whether the number is positive or negative
b. Write a Method to check whether the number is even or odd
c. Write a Method to compare two numbers and return 1 if number1 > number2
or 0 if both are equal or -1 if number1 < number2
d. In the main program, Loop through the array using the length call the method
isPositive() and if positive call method isEven() and print accordingly
e. If the number is negative, print negative.
f. Finally compare the first and last element of the array by calling the method
compare() and display if they are equal, greater, or less*/
using System;

public class NumberCheck
{
    
    public static bool IsPositive(int number)
    {
        return number >= 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 == number2)
            return 0;
        else
            return -1;
    }
}
