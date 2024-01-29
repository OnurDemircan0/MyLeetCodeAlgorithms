/* INSTRUCTIONS

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
*/

/* Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
*/

int[] nums = { -1, -1, 2, 3, 3, 3, 3, 3, 4 };

int MajorityElement(int[] nums)
{
    Dictionary<int, int> dictionary = new Dictionary<int, int>();

    foreach (int num in nums)
    {
        if (dictionary.ContainsKey(num))
        {
            dictionary[num]++;
        }
        else
        {
            dictionary.Add(num, 1);
        }
    }

    return dictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
}


Console.WriteLine(MajorityElement(nums));