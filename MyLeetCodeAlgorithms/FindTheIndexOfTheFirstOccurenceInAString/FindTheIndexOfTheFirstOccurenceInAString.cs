/* INSTRUCTIONS

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
*/

/* Constraints:

1 <= haystack.length, needle.length <= 10^4
haystack and needle consist of only lowercase English characters.
*/

string haystack = "sabutsad";
string needle = "sad";

int StrStr(string haystack, string needle)
{
    for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
    {
        if (haystack[i] == needle[0])
        {
            if (haystack[i..(i + needle.Length)] == needle) return i;
        }
    }
    return -1;
}

Console.WriteLine(StrStr(haystack, needle));