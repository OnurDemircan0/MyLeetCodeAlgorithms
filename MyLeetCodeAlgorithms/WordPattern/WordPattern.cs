/* INSTRUCTIONS

Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
*/

/* Constraints:

1 <= pattern.length <= 300
pattern contains only lower-case English letters.
1 <= s.length <= 3000
s contains only lowercase English letters and spaces ' '.
s does not contain any leading or trailing spaces.
All the words in s are separated by a single space.
*/

string pattern = "abba";
string s = "dog cat cat dog";

bool WordPattern(string pattern, string s)
{
    Dictionary<char, string> dictionary = new Dictionary<char, string>();

    int patternIndex = 0;
    string word = "";

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] != ' ')
        {
            word += s[i];
        }
        else
        {
            if (!(dictionary.ContainsValue(word) ^ dictionary.TryAdd(pattern[patternIndex], word)) || dictionary[pattern[patternIndex]] != word)
            {
                return false;
            }
            word = "";
            patternIndex++;

            if (patternIndex == pattern.Length) return false;
        }
    }

    if (patternIndex != pattern.Length - 1) return false;

    if (!(dictionary.ContainsValue(word) ^ dictionary.TryAdd(pattern[patternIndex], word)) || dictionary[pattern[patternIndex]] != word)
    {
        return false;
    }

    return true;
}

Console.WriteLine(WordPattern(pattern, s));