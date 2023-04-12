/*
 * This application takes input from the user in the form of a four-digit account number.
 * It then checks if the account number is valid by applying a simple check digit algorithm.
 * The check digit algorithm involves dividing the first three digits of the account number by a constant value of 7 to obtain the remainder.
 * If the remainder matches the last digit of the account number, then the account number is considered valid; otherwise, it is invalid.
 * If the user enters an invalid account number that is not exactly four digits long, the program displays an error message.
 * If the account number is valid, the program outputs a message indicating that the account number is valid.
 */

using System;

class CheckDigit
{
    static void Main()
    {
        const int DIGITS = 4;
        const int CHECK_FACTOR = 7;

        Console.Write("Enter a four-digit account number >> ");
        string acctNumString = Console.ReadLine();

        if (acctNumString.Length != DIGITS || !int.TryParse(acctNumString, out int acctNum))
        {
            Console.WriteLine($"Account number invalid - it must have {DIGITS} digits");
            return;
        }

        int firstThree = acctNum / 10;
        int lastOne = acctNum % 10;
        int remainder = firstThree % CHECK_FACTOR;

        if (lastOne == remainder)
        {
            Console.WriteLine("The account number is valid");
        }
        else 
        {
            Console.WriteLine("Invalid");
        }
    }
}
