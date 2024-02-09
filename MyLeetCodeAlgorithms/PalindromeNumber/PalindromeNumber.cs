/* INSTRUCTIONS

Given an integer x, return true if x is a palindrome, and false otherwise.
*/

/* Constraints:

-2^31 <= x <= 2^31 - 1
*/

int x = 1234567899;

bool IsPalindrome(int x)
{
    if(x < 0) return false;

    string xString = x.ToString(); //Convert x to string
    string reversedX = ""; //reversedX will be the reversed version of x

    //Begin with the last character of xString and add it to reversedX. That way reversedX will be completed.
    for (int i = xString.Length - 1; i >= 0; i--)
    {
        reversedX += xString[i];
    }

    //Check if it is palindrome. If x equals to reversed version of itself, that means it's palindrome.
    if(xString == reversedX) return true;
    else return false;
}

Console.WriteLine(IsPalindrome(x));