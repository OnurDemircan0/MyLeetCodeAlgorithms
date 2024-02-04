/* INSTRUCTIONS

Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
*/

/* Constraints:

1 <= s.length <= 5 * 10^4
t.length == s.length
s and t consist of any valid ascii character.
*/

string s = "bbbaaaba";
string t = "aaabbbba";

bool IsIsomorphic(string s, string t)
{
    Dictionary<char, char> dictionary = new Dictionary<char, char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (!(dictionary.ContainsValue(t[i]) ^ dictionary.TryAdd(s[i], t[i])) || dictionary[s[i]] != t[i]) return false;
    }

    return true;
}

Console.WriteLine(IsIsomorphic(s, t));