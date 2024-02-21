/* INSTRUCTIONS

You are given an integer num. You know that Bob will sneakily remap one of the 10 possible digits (0 to 9) to another digit.

Return the difference between the maximum and minimum values Bob can make by remapping exactly one digit in num.

Notes:

When Bob remaps a digit d1 to another digit d2, Bob replaces all occurrences of d1 in num with d2.
Bob can remap a digit to itself, in which case num does not change.
Bob can remap different digits for obtaining minimum and maximum values respectively.
The resulting number after remapping can contain leading zeroes.
*/

/* Constraints:

1 <= num <= 10^8
*/

using System.Text;

int num = 11891;

int MinMaxDifference(int num)
{
    StringBuilder stringBuilder = new StringBuilder(); //Use String Builder for faster operations.
    string numString = num.ToString();
    int maxNum = 0; //Maximum number
    int minNum = 0; //Minimum number
    char digit = '9'; //Maximum digit
    
    for(int i = 0; i < numString.Length; i++)
    {
        //This condition works once.
        if (numString[i] != '9' && digit == '9')
        {
            digit = numString[i]; //The digit that will be changed for the maximum number.
        }

        //If we encounter the digit that will be changed, make it 9.
        if (numString[i] == digit)
        {
            stringBuilder.Append(9);
            continue;
        }

        //If we didn't encounter the digit, leave it as it is.
        stringBuilder.Append(numString[i]);
    }

    maxNum = Convert.ToInt32(stringBuilder.ToString());
    stringBuilder.Clear();
    digit = '0'; //Minimum digit

    for (int i = 0; i < numString.Length; i++)
    {
        //This condition works once.
        if (numString[i] != '0' && digit == '0')
        {
            digit = numString[i]; // The digit that will be changed for the minimum number.
        }

        //If we encounter the digit that will be changed, make it 0.
        if (numString[i] == digit)
        {
            stringBuilder.Append(0);
            continue;
        }

        //If we didn't encounter the digit, leave it as it is.
        stringBuilder.Append(numString[i]);
    }

    minNum = Convert.ToInt32(stringBuilder.ToString());

    return maxNum - minNum;
}

Console.WriteLine(MinMaxDifference(num));