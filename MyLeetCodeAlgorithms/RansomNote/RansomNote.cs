/* INSTRUCTIONS

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.
*/

/* Constraints:

1 <= ransomNote.length, magazine.length <= 10^5
ransomNote and magazine consist of lowercase English letters.
*/

string ransomNote = "sal";
string magazine = "ablnsd";

bool CanConstruct(string ransomNote, string magazine)
{
    List<char> magazineLetters = new List<char>(magazine);

    for (int i = 0; i < ransomNote.Length; i++)
    {
        if (magazineLetters.Contains(ransomNote[i])) magazineLetters.RemoveAt(magazineLetters.IndexOf(ransomNote[i]));
        else return false;
    }

    return true;
}

Console.WriteLine(CanConstruct(ransomNote, magazine));