/* INSTRUCTIONS

Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.
*/

/* Constraints:

1 <= s.length <= 10^4
s consists of only English letters and spaces ' '.
There will be at least one word in s.
*/

string s = "Hello World";

int LengthOfLastWord(string s)
{
    int result = 0;
    bool wordWriting = s[^1] != ' ';

    for (int i = s.Length - 1;  i >= 0; i--)
    {
        if (s[i] != ' ')
        {
            result++;
            wordWriting = true;
        }
        else if(wordWriting)
        {
            return result;
        }
    }

    return result;
}

Console.WriteLine(LengthOfLastWord(s));