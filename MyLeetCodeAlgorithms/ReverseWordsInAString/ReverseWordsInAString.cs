/* INSTRUCTIONS

Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
*/

/* Constraints:

1 <= s.length <= 10^4
s contains English letters (upper-case and lower-case), digits, and spaces ' '.
There is at least one word in s.
*/

string s = "the sky is blue";

string ReverseWords(string s)
{
    string currentWord = "";
    string result = "";

    for(int i = s.Length - 1; i >= 0; i--)
    {
        if (s[i] == ' ')
        {
            if(currentWord.Length != 0)
            {
                if (result.Length != 0) result += " " + currentWord;
                else result += currentWord;

                currentWord = "";
            }
        }
        else
        {
            currentWord = s[i] + currentWord;
        }
    }

    if(currentWord.Length != 0)
    {
        if (result.Length != 0) result += " " + currentWord;
        else result += currentWord;
    }
    
    return result;
}

Console.WriteLine(ReverseWords(s));