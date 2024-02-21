/* INSTRUCTIONS

You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.
*/

/* Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's.
*/

int[] digits = [9, 9, 9, 9];

int[] PlusOne(int[] digits)
{
    int carry = 1; //We want to add one to the value so the carry will be 1 at first.

    for(int i = 1; i <= digits.Length; i++)
    {
        if (carry == 1) digits[^i]++;

        if (digits[^i] == 10)
        {
            digits[^i] = 0;
            carry = 1;
            continue;
        }

        return digits;
    }

    if (carry == 1) digits = [1, .. digits]; //If we still have carry, we will add another digit.

    return digits;
}

Console.WriteLine(PlusOne(digits));