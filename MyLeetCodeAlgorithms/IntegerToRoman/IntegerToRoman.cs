/* INSTRUCTIONS

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral.
*/

/* Constraints:

1 <= num <= 3999
*/

int num = 1997;

string IntToRoman(int num)
{
    Dictionary<int, char> dictionary = new Dictionary<int, char>
    {
        { 1, 'I' },
        { 5, 'V' },
        { 10, 'X' },
        { 50, 'L' },
        { 100, 'C' },
        { 500, 'D' },
        { 1000, 'M' },
    };

    string numString = num.ToString();
    int currentDigit = numString.Length;

    string result = "";

    for (int i = 0; i < numString.Length; i++)
    {
        int currentNumber = numString[i] - '0';
        int power = (int)Math.Pow(10, currentDigit - 1);

        if (currentNumber <= 3)
        {
            for(int j = 0; j < currentNumber; j++)
            {
                result += dictionary[power];
            }
        }
        else if(currentNumber == 4)
        {
            result += dictionary[power];
            result += dictionary[5 * power];
        }
        else if (currentNumber == 5)
        {
            result += dictionary[5 * power];
        }
        else if(currentNumber <= 8)
        {
            result += dictionary[5 * power];

            for (int j = 0; j < currentNumber - 5; j++)
            {
                result += dictionary[power];
            }
        }
        else if(currentNumber == 9)
        {
            result += dictionary[power];
            result += dictionary[power * 10];
        }

        currentDigit--;
    }

    return result;
}

Console.WriteLine(IntToRoman(num));