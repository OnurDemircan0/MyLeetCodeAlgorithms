/* INSTRUCTIONS

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/

/* Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.
*/

string[] strs = { "flower", "flow", "flight" };

string LongestCommonPrefix(string[] strs)
{
    if (strs[0].Length == 0 || strs.Length == 1) return strs[0];

    string prefix = "";

    for (int i = 0; i < strs[0].Length; i++)
    {
        for (int j = 1; j < strs.Length; j++)
        {
            try
            {
                if (strs[j][i] != strs[j - 1][i]) return prefix;
            }
            catch
            {
                return prefix;
            }
        }

        prefix += strs[0][i];
    }

    return prefix;
}

Console.WriteLine(LongestCommonPrefix(strs));