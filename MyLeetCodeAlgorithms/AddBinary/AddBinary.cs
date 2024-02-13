/* INSTRUCTIONS

Given two binary strings a and b, return their sum as a binary string.
*/

/* Constraints:

1 <= a.length, b.length <= 10^4
a and b consist only of '0' or '1' characters.
Each string does not contain leading zeros except for the zero itself.
*/

using System.Text;

string a = "1";
string b = "111";

string AddBinary(string a, string b)
{
    StringBuilder stringBuilder = new StringBuilder();

    int carry = 0;
    int maxLength = Math.Max(a.Length, b.Length);

    for (int i = 0; i < maxLength || carry > 0; i++)
    {
        //If i is less than the length, get the value 0 or 1.
        //Otherwise get 0 because if i is greater than the length, it means the rest of the string must be 0. This situation exists only if a.Length and b.Length is different from each other.
        int digitA = i < a.Length ? a[^(i + 1)] - '0' : 0;
        int digitB = i < b.Length ? b[^(i + 1)] - '0' : 0;

        int sum = digitA + digitB + carry;

        //If digitA andd digitB both are equal to 1 that means we have a carry.
        //Also, if we have a carry before, and one of the digits is 1, we have a carry again.
        carry = sum / 2;

        //Insert 0 or 1 to the left side of the string.
        stringBuilder.Insert(0, sum % 2);
    }

    return stringBuilder.ToString();
}

Console.WriteLine(AddBinary(a, b));