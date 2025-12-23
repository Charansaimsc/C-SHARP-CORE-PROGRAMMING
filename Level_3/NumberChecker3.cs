/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array
b. Method to reverse the digits array
c. Method to compare two arrays and check if they are equal
d. Method to check if a number is a palindrome using the Digits. A palindrome number
is a number that remains the same when its digits are reversed.
e. Method to Check if a number is a duck number using the digits array. A duck number
is a number that has a non-zero digit present in it*/


using System;

public class NumberChecker3
{
    // a) Count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    // a) Store digits in array
    public static int[] StoreDigits(int number)
    {
        int size = CountDigits(number);
        int[] digits = new int[size];

        for (int i = 0; i < size; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    // b) Reverse digits array
    public static int[] ReverseArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        int index = 0;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            reversed[index++] = digits[i];
        }
        return reversed;
    }

    // c) Compare two arrays
    public static bool CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }

    // d) Check Palindrome
    public static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        int[] reversed = ReverseArray(digits);
        return CompareArrays(digits, reversed);
    }

    // e) Check Duck Number
    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                return true;
        }
        return false;
    }
}
