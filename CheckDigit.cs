using System;
using static System.Console;
class CheckDigit
{

static void Main()
{
int acctNum;
string acctNumString;
const int DIGITS = 4;
int firstThree;
int lastOne;
const int CHECK_FACTOR = 7;
int remainder;
Write("Enter a four-digit account number >> ");
acctNumString = ReadLine();
if(acctNumString.Length != DIGITS)
WriteLine($"Account number invalid - it must have {DIGITS} digits");
else
{
acctNum = Convert.ToInt32(acctNumString);
firstThree = acctNum / 10;
lastOne = acctNum % 10;
remainder = firstThree % CHECK_FACTOR;
if (lastOne == remainder)
WriteLine("The account number is valid");
else 
WriteLine("Invalid");



}

}
}
